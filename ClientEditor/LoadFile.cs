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

        private static bool ReadFile(int editor)
        {
            switch(editor)
            {
                case 1: Data<CharColor>.CharColorList = new List<CharColor>();
                    break;
                case 2: Data<ClassBase>.ClassBaseList = new List<ClassBase>();
                    break;
                case 3: Data<DyingItems>.DyingItemsList = new List<DyingItems>();
                    break;
                case 4: Data<Adventureroad>.AdventureRoadList = new List<Adventureroad>();
                    break;
                case 5: Data<Pvp>.PvpList = new List<Pvp>();
                    break;
                case 6: Data<Fight>.FightList = new List<Fight>();
                    break;
                case 7: Data<Mage>.MageList = new List<Mage>();
                        break;
                case 8: Data<PartnerGrow>.PartnerGrowList = new List<PartnerGrow>();
                    break;
                case 9: Data<PartnerTalk>.PartnerTalkList = new List<PartnerTalk>();
                    break;
                case 10: Data<Growequip>.GrowEquipList = new List<Growequip>();
                    break;
                case 11: Data<Dialogue>.DialogList = new List<Dialogue>();
                    break;
                case 12: Data<Level>.LevelList = new List<Level>();
                    break;
            }

            FileStream fs = null;
            StreamReader reader = null;
            try
            {
                fs = new FileStream(Settings.File, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs, Encoding.GetEncoding(950));
                string line = "";
                line = reader.ReadLine();
                string[] versionArray = new string[4];
                     
                versionArray = line.Split('|');
                Console.WriteLine(versionArray[0]);
                string[] objectArray = new string[int.Parse(versionArray[2])];
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
                    case 4: Settings.AdventureVersion = line;
                        break;
                    case 5: Settings.PvpVersion = line;
                        break;
                    case 6: Settings.FightVersion = line;
                        break;
                    case 7: Settings.MageVersion = line;
                        break;
                    case 8: Settings.PartnerGrowVersion = line;
                        break;
                    case 9: Settings.PartnerTalkVersion = line;
                        break;
                    case 10: Settings.GrowEquipVersion = line;
                        break;
                    case 11: Settings.DialogVersion = line;
                        break;
                    case 12: Settings.LevelVersion = line;
                        break;
                }


                for (int i = 0; i < File.ReadAllLines(Settings.File).Length - 1; i++)
                {
                    line = reader.ReadLine();
                    objectArray = line.Split('|');
                    switch (editor)
                    {
                        case 1:
                            Data<CharColor>.CharColorList.Add(new CharColor(objectArray[0], objectArray[1], objectArray[2], objectArray[3], (objectArray[4])));
                            break;
                        case 2:
                            Data<ClassBase>.ClassBaseList.Add(new ClassBase(objectArray[0],
                                                                 objectArray[1],
                                                                 objectArray[2],
                                                                 objectArray[3],
                                                                 objectArray[4],
                                                                 objectArray[5],
                                                                 objectArray[6],
                                                                 objectArray[7]));
                            break;
                        case 3:
                            Data<DyingItems>.DyingItemsList.Add(new DyingItems(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8],
                                objectArray[9],
                                objectArray[10],
                                objectArray[11],
                                objectArray[12],
                                objectArray[13],
                                objectArray[14],
                                objectArray[15],
                                objectArray[16],
                                objectArray[17],
                                objectArray[18],
                                objectArray[19],
                                objectArray[20],
                                objectArray[21],
                                objectArray[22],
                                objectArray[23],
                                objectArray[24],
                                objectArray[25]));
                            break;
                        case 4:   
                            Data<Adventureroad>.AdventureRoadList.Add(new Adventureroad(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8],
                                objectArray[9],
                                objectArray[10],
                                objectArray[11],
                                objectArray[12]));
                            break;
                        case 5:
                            Data<Pvp>.PvpList.Add(new Pvp(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8]));
                            break;
                        case 6:
                            Data<Fight>.FightList.Add(new Fight(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8],
                                objectArray[9],
                                objectArray[10],
                                objectArray[11],
                                objectArray[12],
                                objectArray[13],
                                objectArray[14],
                                objectArray[15],
                                objectArray[16],
                                objectArray[17],
                                objectArray[18],
                                objectArray[19],
                                objectArray[20],
                                objectArray[21],
                                objectArray[22],
                                objectArray[23],
                                objectArray[24],
                                objectArray[25],
                                objectArray[26],
                                objectArray[27],
                                objectArray[28]));
                            break;
                        case 7:
                            Data<Mage>.MageList.Add(new Mage(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8],
                                objectArray[9],
                                objectArray[10],
                                objectArray[11],
                                objectArray[12],
                                objectArray[13],
                                objectArray[14],
                                objectArray[15],
                                objectArray[16],
                                objectArray[17],
                                objectArray[18],
                                objectArray[19],
                                objectArray[20],
                                objectArray[21]));
                            break;
                        case 8:
                            Data<PartnerGrow>.PartnerGrowList.Add(new PartnerGrow(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8],
                                objectArray[9],
                                objectArray[10],
                                objectArray[11],
                                objectArray[12],
                                objectArray[13],
                                objectArray[14],
                                objectArray[15],
                                objectArray[16],
                                objectArray[17],
                                objectArray[18],
                                objectArray[19],
                                objectArray[20],
                                objectArray[21],
                                objectArray[22],
                                objectArray[23],
                                objectArray[24],
                                objectArray[25],
                                objectArray[26],
                                objectArray[27],
                                objectArray[28],
                                objectArray[29],
                                objectArray[30],
                                objectArray[31],
                                objectArray[32],
                                objectArray[33],
                                objectArray[34],
                                objectArray[35],
                                objectArray[36],
                                objectArray[37],
                                objectArray[38],
                                objectArray[39],
                                objectArray[40],
                                objectArray[41],
                                objectArray[42],
                                objectArray[43],
                                objectArray[44],
                                objectArray[45],
                                objectArray[46],
                                objectArray[47],
                                objectArray[48],
                                objectArray[49],
                                objectArray[50],
                                objectArray[51],
                                objectArray[52],
                                objectArray[53],
                                objectArray[54],
                                objectArray[55],
                                objectArray[56],
                                objectArray[57],
                                objectArray[58],
                                objectArray[59],
                                objectArray[60]));
                            break;
                        case 9:
                            Data<PartnerTalk>.PartnerTalkList.Add(new PartnerTalk(objectArray[0],
                                                                 objectArray[1],
                                                                 objectArray[2],
                                                                 objectArray[3],
                                                                 objectArray[4],
                                                                 objectArray[5],
                                                                 objectArray[6]));
                            break;
                        case 10: Data<Growequip>.GrowEquipList.Add(new Growequip(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8],
                                objectArray[9],
                                objectArray[10],
                                objectArray[11],
                                objectArray[12],
                                objectArray[13],
                                objectArray[14]));
                            break;
                        case 11: Data<Dialogue>.DialogList.Add(new Dialogue(objectArray[0], objectArray[1]));
                            break;
                        case 12:
                            Data<Level>.LevelList.Add(new Level(
                                objectArray[0],
                                objectArray[1],
                                objectArray[2],
                                objectArray[3],
                                objectArray[4],
                                objectArray[5],
                                objectArray[6],
                                objectArray[7],
                                objectArray[8],
                                objectArray[9],
                                objectArray[10],
                                objectArray[11],
                                objectArray[12],
                                objectArray[13],
                                objectArray[14],
                                objectArray[15],
                                objectArray[16],
                                objectArray[17],
                                objectArray[18],
                                objectArray[19],
                                objectArray[20],
                                objectArray[21],
                                objectArray[22],
                                objectArray[23],
                                objectArray[24],
                                objectArray[25],
                                objectArray[26],
                                objectArray[27],
                                objectArray[28],
                                objectArray[29],
                                objectArray[30],
                                objectArray[31],
                                objectArray[32],
                                objectArray[33],
                                objectArray[34],
                                objectArray[35],
                                objectArray[36],
                                objectArray[37],
                                objectArray[38],
                                objectArray[39],
                                objectArray[40],
                                objectArray[41]));
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
            catch(FormatException ex)
            {
                MessageBox.Show("Wrong file opened.");
                Console.WriteLine(ex.StackTrace);
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


        public static bool LoadFunction(ListBox l, TextBlock t)
        {
            bool value = false;
            try
            {
                LoadFile f = new LoadFile();
                value = ReadFile(Settings.EditorID); // result komen
                switch(Settings.EditorID)
                {
                    case 1:
                        for (int i = 1; i <= Data<CharColor>.CharColorList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.CharColorVersion;
                        break;
                    case 2:
                        for (int i = 1; i <= Data<ClassBase>.ClassBaseList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.ClassBaseVersion;
                        break;
                    case 3: 
                        for(int i = 1; i<= Data<DyingItems>.DyingItemsList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.DyingItemsVersion;
                        break;
                    case 4:
                        for(int i = 1; i <= Data<Adventureroad>.AdventureRoadList.Count;i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.AdventureVersion;
                        break;
                    case 5: 
                        for(int i = 1; i<= Data<Pvp>.PvpList.Count;i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.PvpVersion;
                        break;
                    case 6:
                        for(int i = 1; i<=Data<Fight>.FightList.Count;i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.FightVersion;
                        break;
                    case 7:
                        for(int i = 1; i<=Data<Mage>.MageList.Count;i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.MageVersion;
                        break;
                    case 8:
                        for(int i = 1; i <=Data<PartnerGrow>.PartnerGrowList.Count;i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.PartnerGrowVersion;
                        break;
                    case 9:
                        for(int i = 1;i<=Data<PartnerTalk>.PartnerTalkList.Count;i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.PartnerTalkVersion;
                        break;
                    case 10:
                        for(int i = 1; i<=Data<Growequip>.GrowEquipList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.GrowEquipVersion;
                        break;
                    case 11:
                        for (int i = 1; i <= Data<Dialogue>.DialogList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.DialogVersion;
                        break;
                    case 12:
                        for(int i = 1; i<=Data<Level>.LevelList.Count;i++)
                        {
                            l.Items.Add(i);
                        }
                        t.Text = Settings.LevelVersion;
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
