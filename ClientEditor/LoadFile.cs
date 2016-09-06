﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ClientEditor
{
    public class LoadFile
    {
        public LoadFile()
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "ini Files (.ini)|*.ini|All Files (*.*)|*.*";
            filedialog.FilterIndex = 1;
            if(filedialog.ShowDialog() == true)
            {
                Settings.File = filedialog.FileName;
            }
   
        }

        public static bool ReadFile(int aos, int editor)
        {
            switch(editor)
            {
                case 1: Data.CharColorList = new List<CharColor>();
                    break;
                case 2: Data.ClassBaseList = new List<ClassBase>();
                    break;
                case 3: Data.DyingItemsList = new List<DyingItems>();
                    break;
            }

            FileStream fs = null;
            StreamReader reader = null;
            try
            {
                fs = new FileStream(Settings.File, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs, Encoding.GetEncoding(950));
                string line = "";
                string[] objectArray = new string[aos];

                line = reader.ReadLine();
                switch (editor)
                {
                    case 1:
                        Settings.CharColorVersion = line;
                        break;
                    case 2: 
                        Settings.ClassBaseVersion = line;
                        break;
                    case 3:
                        Settings.DyingItemsVersion = line;
                        break;
                }


                for (int i = 0; i < File.ReadAllLines(Settings.File).Length - 1; i++)
                {
                    line = reader.ReadLine();
                    objectArray = line.Split('|');
                    switch (editor)
                    {
                        case 1:
                            Data.CharColorList.Add(new CharColor(int.Parse(objectArray[0]), objectArray[1], int.Parse(objectArray[2]), int.Parse(objectArray[3]), int.Parse(objectArray[4])));
                            break;
                        case 2:
                            Data.ClassBaseList.Add(new ClassBase(objectArray[0],
                                                                 objectArray[1],
                                                                 objectArray[2],
                                                                 objectArray[3],
                                                                 objectArray[4],
                                                                 objectArray[5],
                                                                 objectArray[6],
                                                                 objectArray[7]));
                            break;
                        case 3:
                            Data.DyingItemsList.Add(new DyingItems(
                                int.Parse(objectArray[0]),
                                int.Parse(objectArray[1]),
                                int.Parse(objectArray[2]),
                                int.Parse(objectArray[3]),
                                int.Parse(objectArray[4]),
                                int.Parse(objectArray[5]),
                                int.Parse(objectArray[6]),
                                int.Parse(objectArray[7]),
                                int.Parse(objectArray[8]),
                                int.Parse(objectArray[9]),
                                int.Parse(objectArray[10]),
                                int.Parse(objectArray[11]),
                                int.Parse(objectArray[12]),
                                int.Parse(objectArray[13]),
                                int.Parse(objectArray[14]),
                                int.Parse(objectArray[15]),
                                int.Parse(objectArray[16]),
                                int.Parse(objectArray[17]),
                                int.Parse(objectArray[18]),
                                int.Parse(objectArray[19]),
                                int.Parse(objectArray[20]),
                                int.Parse(objectArray[21]),
                                int.Parse(objectArray[22]),
                                int.Parse(objectArray[23]),
                                int.Parse(objectArray[24]),
                                int.Parse(objectArray[25])));
                            break;
                        default: throw new EditorNotFoundException("Editor not Found");
                    }
                }
                MessageBox.Show("Finished reading file.");
                return true;
            }
            catch (EditorNotFoundException ex)
            {
                throw ex;
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong file opened.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please select a file to load.");
            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong with reading the file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return false;
        }


        public static bool LoadFunction(ListBox l, TextBlock t, int aol)
        {
            bool value = false;
            try
            {
                LoadFile f = new LoadFile();
                value = ReadFile(aol, Settings.EditorID); // result komen
                switch(Settings.EditorID)
                {
                    case 1:
                        for (int i = 1; i <= Data.CharColorList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.CharColorVersion;
                        break;
                    case 2:
                        for (int i = 1; i <= Data.ClassBaseList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.ClassBaseVersion;
                        break;
                    case 3: 
                        for(int i = 1; i< Data.DyingItemsList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.DyingItemsVersion;
                        break;
                }
                return value;
            }
            catch (EditorNotFoundException)
            {
                MessageBox.Show("Editor not supported, Application will close.");
                Environment.Exit(1);
            }
            return value;
        }




    }
}
