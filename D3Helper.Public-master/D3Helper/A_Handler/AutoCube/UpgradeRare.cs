﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Enigma.D3;
using Enigma.D3.UI;
using D3Helper.A_Enums;
using Enigma.D3.Helpers;
<<<<<<< HEAD
=======
using System.Globalization;
>>>>>>> 6e63c22a3c22a1a578dcec39133c7556614a3682

namespace D3Helper.A_Handler.AutoCube
{
    class UpgradeRare
    {
        public static bool IsUpgrading_Rare = false;
        public static bool StopConversion = false;
        public static void DoUpgrade()
        {
            try
            {
                IsUpgrading_Rare = true;
                ActorCommonData CubeStand;

                bool CubeNearby = Tools.IsCubeNearby(out CubeStand);
                var UpgradableItems = Tools.Get_Items("rare");

<<<<<<< HEAD
                if (CubeNearby & UpgradableItems.Count > 0)
=======
                int Count_AvailableEnchants = (int)Tools.Get_AvailableEnchants_UpgradeRare();
                
                if (CubeNearby & UpgradableItems.Count > 0 & Count_AvailableEnchants > 0)
>>>>>>> 6e63c22a3c22a1a578dcec39133c7556614a3682
                {
                    if (Tools.ClickOnCube(CubeStand))
                    {
                        Stopwatch s1 = new Stopwatch(); /////////
<<<<<<< HEAD
                        s1.Start(); ///////////
                        var Count_AvailableEnchants = 50;
                        var Count_Enchants = 0;
=======
                        s1.Start(); ///////////                        
                        int Count_Enchants = 0;

>>>>>>> 6e63c22a3c22a1a578dcec39133c7556614a3682
                        //receipe button
                        A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Recipe_Button);
                        Thread.Sleep(5);
                        //press next button 2x for upgrade rare menu
                        A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Page_Next);
                        Thread.Sleep(5);
                        A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Page_Next);
                        Thread.Sleep(5);
                        int numberOfItemsBeforeTrying = UpgradableItems.Count;
                        //var a = UpgradableItems.Where(a => a.);

                        foreach (var item in UpgradableItems)
                        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
                            if(Count_Enchants == Count_AvailableEnchants)
=======
                            if (StopConversion)
                            {
                                break;
                            }
                            if (Count_Enchants == Count_AvailableEnchants)
>>>>>>> f27d9ee9b9e5163e2841abc63d0741440127868c
                            {
                                break;
                            }
                            Count_Enchants++;
<<<<<<< HEAD
>>>>>>> 6e63c22a3c22a1a578dcec39133c7556614a3682
                            if (true)
=======
                            if (Tools.ClickOnCube(CubeStand))
>>>>>>> f27d9ee9b9e5163e2841abc63d0741440127868c
                            {
                                //put item in cube
                                UIRect UIRect_item =
                                    A_Collection.D3UI.InventoryItemUIRectMesh.FirstOrDefault(
                                        x => x.Key.ItemSlotX == item.x118_ItemSlotX && x.Key.ItemSlotY == item.x11C_ItemSlotY).Value;

                                A_Tools.T_D3UI.UIElement.rightClick(UIRect_item);
                                //fill
                                A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Fill_Button);
                                //transmute
                                A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Transmute_Button);
                                Thread.Sleep(Properties.Settings.Default.SleepTransmute);
                                //click next and back to reset
                                A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Page_Next);
                                A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Page_Previous);
                            }
                        }
                        //close all windows
                        int close_timeout = 5;
                        while (Tools.IsKanaisCube_MainPage_Visible())
                        {
                            //A_Tools.InputSimulator.IS_Keyboard.Close_AllWindows(); //doesnt work if not assigned :D
                            //Press "X" - Button in Kanais Cube
                            A_Tools.T_D3UI.UIElement.leftClick(UIElements.Kanai_Cube_Exit_Button);

                            close_timeout--;
                            if (close_timeout == 0)
                            {
                                break;
                            }
                            Thread.Sleep(200);
                        }
                        s1.Stop(); /////////
                        TimeSpan t1 = s1.Elapsed; //////
                        Console.WriteLine(t1.TotalSeconds); ////////
                    }
                }
                if (Properties.Settings.Default.RosBotUpgradeKadalaBool)
                {
                    WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.F6);
                }
                IsUpgrading_Rare = false;
            }
            catch (Exception)
            {
                IsUpgrading_Rare = false;
            }
        }
    }
}
