using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using MetroFramework.Forms;
using System.Data;
using MetroFramework;


using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace WindowsFormsApp1_geponAuto_20200415
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
            ToggleControls(false);

            ////test timer
            int interval = 1000;
            test_timer = new System.Timers.Timer(interval);
            test_timer.AutoReset = true;
            test_timer.Elapsed += new System.Timers.ElapsedEventHandler(test_timer_tick);

            portRefresh();
        }
        #region  frame

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //  metroStyleManager1.Theme = metroStyleManager1.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;

        }

        private void metroTileSwitch_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample MetroMessagebox `OK` only button", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample MetroMessagebox `OK` and `Cancel` button", "MetroMessagebox", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample MetroMessagebox `Yes` and `No` button", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample MetroMessagebox `Yes`, `No` and `Cancel` button", "MetroMessagebox", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample `default` MetroMessagebox ", "MetroMessagebox");

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample MetroMessagebox `Retry` and `Cancel` button.  With warning style.", "MetroMessagebox", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample MetroMessagebox `Abort`, `Retry` and `Ignore` button.  With Error style.", "MetroMessagebox", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //  metroContextMenu2.Show(metroButton4, new Point(0, metroButton4.Height));

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroTile8, new Point(0, metroTile8.Height));

        }


        public event EventHandler SendMsgEvent; //use Invoke
        public event EventHandler SendMsgEvent1;

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();

            //slaver trans to master
            Form2.ChangeTheme = (MetroThemeStyle) => metroStyleManager.Theme = MetroThemeStyle;//lambda
            Form2.ChangeStyle = (MetroColorStyle) => metroStyleManager.Style = MetroColorStyle;

            //master trans to slaver
            SendMsgEvent += Form2.MainFormThemeChaned;//for slaver sets
            SendMsgEvent1 += Form2.MainFormStyleChaned;


            Form2.Show();
            SendMsgEvent(this, new TransEventArg() { Theme = this.metroStyleManager.Theme });  //master trans to slaver
            SendMsgEvent1(this, new TransEventArg() { Style = this.metroStyleManager.Style });  //master trans to slaver

            while (!Form2.IsDisposed)
            {
                Application.DoEvents();
                this.Enabled = false;
            }
            this.Enabled = true;

        }

        private void metroContextMenu2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void metroToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void metroContextMenu1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region  charts

        //osCount f1Count   g1rCount    g1wCount    e1rCount e1wCount f2Count g2rCount g2wCount e2rCount e2wCount
        double osCount = 0;

        double f1Count = 0;
        double g1rCount = 0;
        double g1wCount = 0;
        double e1rCount = 0;
        double e1wCount = 0;

        double f2Count = 0;
        double g2rCount = 0;
        double g2wCount = 0;
        double e2rCount = 0;
        double e2wCount = 0;

        //  int[] intArray = new int[11];

        private void cartesianChart1_Load()
        {
            if (portFxCheckBox.Checked)
            {
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = "Count: ",
                    Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                    new ObservableValue(f2Count),
                    new ObservableValue(g2rCount),
                    new ObservableValue(g2wCount),
                    new ObservableValue(e2rCount),
                    new ObservableValue(e2wCount),
                },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " "
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                    "Optical Switch",
                    "FOH-100 No.1",
                    "1GPON Right",
                    "1GPON Wrong",
                    "1EPON Right",
                    "1EPON Wrong",

                    "FOH-100 No.2",
                    "2GPON Right",
                    "2GPON Wrong",
                    "2EPON Right",
                    "2EPON Wrong"
                },
                    Separator = new Separator // force the separator step to 1, so it always display all labels
                    {
                        Step = 1,
                        IsEnabled = false //disable it to make it invisible.
                    },
                    LabelsRotation = 15
                });
            }
            else
            {
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = "Count: ",
                    Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                    //new ObservableValue(f2Count),
                    //new ObservableValue(g2rCount),
                    //new ObservableValue(g2wCount),
                    //new ObservableValue(e2rCount),
                    //new ObservableValue(e2wCount),
                },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " "
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                    "Optical Switch",
                    "FOH-100 No.1",
                    "1GPON Right",
                    "1GPON Wrong",
                    "1EPON Right",
                    "1EPON Wrong",

                    //"FOH-100 No.2",
                    //"2GPON Right",
                    //"2GPON Wrong",
                    //"2EPON Right",
                    //"2EPON Wrong"
                },
                    Separator = new Separator // force the separator step to 1, so it always display all labels
                    {
                        Step = 1,
                        IsEnabled = false //disable it to make it invisible.
                    },
                    LabelsRotation = 15
                });

            }
            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value + ".00 items",
                Separator = new Separator()
            });
        } 

        private void Labels_Load(object sender, EventArgs e)
        {
            //if (portFxCheckBox.Checked)
            //{
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = "Count: ",
                    Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                    new ObservableValue(f2Count),
                    new ObservableValue(g2rCount),
                    new ObservableValue(g2wCount),
                    new ObservableValue(e2rCount),
                    new ObservableValue(e2wCount),
                },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " "
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                    "Optical Switch",
                    "FOH-100 No.1",
                    "1GPON Right",
                    "1GPON Wrong",
                    "1EPON Right",
                    "1EPON Wrong",

                    "FOH-100 No.2",
                    "2GPON Right",
                    "2GPON Wrong",
                    "2EPON Right",
                    "2EPON Wrong"
                },
                    Separator = new Separator // force the separator step to 1, so it always display all labels
                    {
                        Step = 1,
                        IsEnabled = false //disable it to make it invisible.
                    },
                    LabelsRotation = 15
                });
       //     }
            //else
            //{
            //    cartesianChart1.Series.Add(new ColumnSeries
            //    {
            //        Title = "Count: ",
            //        Values = new ChartValues<ObservableValue>
            //    {
            //        new ObservableValue(osCount),
            //        new ObservableValue(f1Count),
            //        new ObservableValue(g1rCount),
            //        new ObservableValue(g1wCount),
            //        new ObservableValue(e1rCount),
            //        new ObservableValue(e1wCount),
            //        //new ObservableValue(f2Count),
            //        //new ObservableValue(g2rCount),
            //        //new ObservableValue(g2wCount),
            //        //new ObservableValue(e2rCount),
            //        //new ObservableValue(e2wCount),
            //    },
            //        DataLabels = true,
            //        LabelPoint = point => point.Y + " "
            //    });

            //    cartesianChart1.AxisX.Add(new Axis
            //    {
            //        Labels = new[]
            //        {
            //        "Optical Switch",
            //        "FOH-100 No.1",
            //        "1GPON Right",
            //        "1GPON Wrong",
            //        "1EPON Right",
            //        "1EPON Wrong",

            //        //"FOH-100 No.2",
            //        //"2GPON Right",
            //        //"2GPON Wrong",
            //        //"2EPON Right",
            //        //"2EPON Wrong"
            //    },
            //        Separator = new Separator // force the separator step to 1, so it always display all labels
            //        {
            //            Step = 1,
            //            IsEnabled = false //disable it to make it invisible.
            //        },
            //        LabelsRotation = 15
            //    });

            //}
            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value + ".00 items",
                Separator = new Separator()
            });


            usb = new USB();
            usb2 = new USB();
        }

        //refresh cartesianChart1
        private void refreshCartesianChart1()
        {
            if (portFxCheckBox.Checked)
            {
                cartesianChart1.Series.Clear();// Values.Clear();

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = "Count: ",

                    Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                    new ObservableValue(f2Count),
                    new ObservableValue(g2rCount),
                    new ObservableValue(g2wCount),
                    new ObservableValue(e2rCount),
                    new ObservableValue(e2wCount),
                },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " "
                });
            }
            else
            {
                cartesianChart1.Series.Clear();// Values.Clear();

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = "Count: ",

                    Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                    //new ObservableValue(f2Count),
                    //new ObservableValue(g2rCount),
                    //new ObservableValue(g2wCount),
                    //new ObservableValue(e2rCount),
                    //new ObservableValue(e2wCount),
                },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " "
                });
            }
        }



        #endregion


        #region serial

        public USB usb;
        public USB usb2;
        private Thread thread;

        int sendCount = 1;   //send command times
        Boolean isExit = false;
        private Boolean isOpen = false;

        private int timerDrawI = 0;

        ///test timer             
        System.Timers.Timer test_timer;
        long TimeCount;
        //delegate
        public delegate void SetControlValue(long value);

        string foh100_state_command = "system state" + "\r\n";
        string switch_command1 = "01";// "<AD01_S_01>";
        string switch_command2 = "02";//"<AD01_S_02>";
        string ponState = "";
        string ponState1 = "";


        #region  test timer label
        private void test_timer_tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new SetControlValue(ShowTime), TimeCount);
            TimeCount++;
        }

        private void ShowTime(long t)
        {
            TimeSpan temp = new TimeSpan(0, 0, (int)t);
            timerLabel.Text = "Timer：" + string.Format("{0:00}:{1:00}:{2:00}", temp.Hours, temp.Minutes, temp.Seconds);
        }

        #endregion

        private void portRefresh()
        {
            //ComboBox cbnMine = new ComboBox();
            foreach (Control c in extendedPanel1.Controls)
            {
                if (c is MetroFramework.Controls.MetroComboBox)
                {
                    c.Click += delegate (object sender, EventArgs e)
                    {

                        ((ComboBox)sender).Items.Clear();
                        try
                        {
                            List<string> list = new List<string>();
                            string[] ports = USB.GetPorts(); //SerialPort.GetPortNames();//

                            ((ComboBox)sender).Items.Clear();
                            for (int i = 0; i < ports.Length; i++)
                            {
                                ((ComboBox)sender).Items.Add(ports[i]);
                            }
                            if (ports.Length > 0)
                            {
                                ((ComboBox)sender).SelectedIndex = ports.Length - 1;
                            }
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK);

                        }
                    };
                }

            }

        }
        private void f_timerDrawStart()
        {
            timerDrawI = 0;

            //set  timerDraw.Interval
            int current;
            if (int.TryParse(autoPeriodTextBox.Text.ToString(), out current))
            {
                if (current > 40)  // && current < 300
                {
                    timerDraw.Interval = current * 1000;
                }
                else
                {
                    autoPeriodTextBox.Text = "60";
                    timerDraw.Interval = 60000; ;
                }
            }
            else
            {
                autoPeriodTextBox.Text = "60";
                timerDraw.Interval = 60000; ;
            }
            timerDraw.Start();

        }

        private void ToggleControls(bool value)
        {
            portComboBox1.Enabled = !value;
            portComboBox2.Enabled = !value;
            portComboBox3.Enabled = !value;
            autoPeriodTextBox.Enabled = !value;
            manulCheckBox.Enabled = !value;
            portFxCheckBox.Enabled = !value;

            timerLabel.Visible = value;
        }
        //force quit form 
        protected override void WndProc(ref Message msg)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
            {
                usb.CloseCom();
                isExit = true;
            }
            base.WndProc(ref msg);
        }

        private void portButton_Click(object sender, EventArgs e)
        {
            if (portFxCheckBox.Checked)
            {
                if (!isOpen)
                {
                    try
                    {

                        Boolean isOpenSuccess = usb.SetCom(portComboBox1.SelectedItem.ToString()) && usb.SetCom_two(portComboBox2.SelectedItem.ToString()) && usb2.SetCom(portComboBox3.SelectedItem.ToString());
                        if (isOpenSuccess)
                        {
                            isOpen = true;
                            ToggleControls(true);
                            portButton.Text = "Close";

                            sendCount = 1;
                        }
                        else
                        {
                            isOpen = false;
                            usb.CloseCom();
                            usb2.CloseCom();
                            usb.CloseCom_two();
                            ToggleControls(false);
                            portButton.Text = "Open";
                          //  MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                        // return;
                    }
                }
                else
                {
                    usb.CloseCom();
                    usb2.CloseCom();
                    usb.CloseCom_two();
                    ToggleControls(false);
                    portButton.Text = "Open";
                    isOpen = false;
                }

            }
            else
            {
                if (!isOpen)
                {
                    try
                    {

                        Boolean isOpenSuccess = usb.SetCom(portComboBox1.SelectedItem.ToString()) && usb.SetCom_two(portComboBox2.SelectedItem.ToString());
                        if (isOpenSuccess)
                        {
                            isOpen = true;
                            ToggleControls(true);
                            portButton.Text = "Close";

                            sendCount = 1;
                        }
                        else
                        {
                            timerDraw.Stop();
                            test_timer.Stop();

                            isOpen = false;
                            usb.CloseCom();
                            usb.CloseCom_two();
                            ToggleControls(false);
                            portButton.Text = "Open";
                           // MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                        // return;
                    }
                }
                else
                {
                    timerDraw.Stop();
                    test_timer.Stop();

                    usb.CloseCom();
                    usb2.CloseCom();
                    usb.CloseCom_two();
                    ToggleControls(false);
                    portButton.Text = "Open";
                    isOpen = false;
                }

            }

        }


        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(2);
        static void AcessDatabase(string name, int seconds)
        {

        }
        private void timerDraw_Tick(object sender, EventArgs e)
        {
            if (portFxCheckBox.Checked)
            {
                bool channelChanged = usb.ChangeChannel(switch_command1);

                if (!channelChanged)
                {
                    timerDraw.Stop();
                    test_timer.Stop();
                    MetroMessageBox.Show(this, "\r\n\r\n" + "Optical switch write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // return;
                }
                else
                {
                    // usb.Delay(30000); //F show switch success needs 30s

                    this.BeginInvoke(new Action(() =>
                    {
                        osCount++;
                        refreshCartesianChart1();
                    }));

                    for (int i = 0; i < (Convert.ToInt32(autoPeriodTextBox.Text.ToString()) - 30) / 5; i++)
                    {
                        var t1 = new Thread(() => foh100_state());
                        var t2 = new Thread(() => foh100_state1());
                        t1.Start();
                        t2.Start();
                        t1.Join();
                        t2.Join();

                        usb.Delay(3000);

                    this.Invoke(new Action(() =>
                        {
                            if (ponState == "0")
                            {
                                g1rCount++;
                            }
                            else// (ponState == "1")
                            {
                                g1wCount++;
                            }
                            f1Count++;

                            if (ponState1 == "0")
                            {
                                g2rCount++;
                            }
                            else// (ponState == "1")
                        {
                                g2wCount++;
                            }
                            f2Count++;
                            refreshCartesianChart1();
                        }));
                        usb.Delay(500);
                    }
                }
                channelChanged = usb.ChangeChannel(switch_command2);
                if (!channelChanged)
                {
                    timerDraw.Stop();
                    test_timer.Stop();
                    MetroMessageBox.Show(this, "\r\n\r\n" + "Optical switch write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        osCount++;
                        refreshCartesianChart1();
                    }));

                    for (int i = 0; i < (Convert.ToInt32(autoPeriodTextBox.Text.ToString()) - 30) / 5; i++)
                    {
                        var t1 = new Thread(() => foh100_state());
                        var t2 = new Thread(() => foh100_state1());
                        t1.Start();
                        t2.Start();
                        t1.Join();
                        t2.Join();

                        usb.Delay(3000);

                        this.Invoke(new Action(() =>
                        {
                            if (ponState == "1")
                            {
                                e1rCount++;
                            }
                            else// (ponState == "1")
                            {
                                e1wCount++;
                            }
                            f1Count++;

                            if (ponState1 == "0")
                            {
                                e2rCount++;
                            }
                            else// (ponState == "1")
                            {
                                e2wCount++;
                            }
                            f2Count++;
                            refreshCartesianChart1();
                        }));
                        usb.Delay(500);
                    }
                }

            }
            else
            {
                bool channelChanged = usb.ChangeChannel(switch_command1);

                if (!channelChanged)
                {
                    timerDraw.Stop();
                    test_timer.Stop();
                    MetroMessageBox.Show(this, "\r\n\r\n" + "Optical switch write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // return;
                }
                else
                {
                    // usb.Delay(30000); //F show switch success needs 30s

                    this.BeginInvoke(new Action(() =>
                    {
                        osCount++;
                        refreshCartesianChart1();
                    }));

                    //  reader count : (Convert.ToInt32( autoPeriodTextBox.Text.ToString()) - 30 ) / 5
                    for (int i = 0; i < (Convert.ToInt32(autoPeriodTextBox.Text.ToString()) - 30) / 5; i++)
                    {
                        foh100_state();
                        usb.Delay(3000);
                        this.Invoke(new Action(() =>

                        {
                            if (ponState == "0")
                            {
                                g1rCount++;
                            }
                            else// (ponState == "1")
                            {
                                g1wCount++;
                            }
                            f1Count++;
                            refreshCartesianChart1();
                        }));
                        usb.Delay(500);
                    }

                    channelChanged = usb.ChangeChannel(switch_command2);
                    if (!channelChanged)
                    {
                        timerDraw.Stop();
                        test_timer.Stop();
                        MetroMessageBox.Show(this, "\r\n\r\n" + "Optical switch write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            osCount++;
                            refreshCartesianChart1();
                        }));

                        // for (int i = 0; i < 4; i++)
                        for (int i = 0; i < (Convert.ToInt32(autoPeriodTextBox.Text.ToString()) - 30) / 5; i++)
                        {
                            foh100_state();
                            usb.Delay(3000);
                            this.Invoke(new Action(() =>

                            {
                                if (ponState == "1")
                                {
                                    e1rCount++;
                                }
                                else// (ponState == "1")
                                {
                                    e1wCount++;
                                }
                                f1Count++;
                                refreshCartesianChart1();
                            }));
                            usb.Delay(100);
                        }
                    }
                }

                channelChanged = usb.ChangeChannel(switch_command2);
                if (!channelChanged)
                {
                    timerDraw.Stop();
                    test_timer.Stop();
                    MetroMessageBox.Show(this, "\r\n\r\n" + "Optical switch write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        osCount++;
                        refreshCartesianChart1();
                    }));

                    // for (int i = 0; i < 4; i++)
                    for (int i = 0; i < (Convert.ToInt32(autoPeriodTextBox.Text.ToString()) - 30) / 5; i++)
                    {
                        foh100_state();
                        usb.Delay(3000);
                        this.Invoke(new Action(() =>

                        {
                            if (ponState == "1")
                            {
                                e1rCount++;
                            }
                            else// (ponState == "1")
                            {
                                e1wCount++;
                            }
                            f1Count++;
                            refreshCartesianChart1();
                        }));
                        usb.Delay(100);
                    }
                }
            }

            timerDrawI++;
            Thread.Sleep(100);
        }

        private void foh100_state()
        {
            if (isOpen)
            {
                try
                {
                    ///* usb.SendData_two(switch_command1);  *///GPON
                    // bool channelChanged = usb.ChangeChannel(switch_command1);
                    // if (!channelChanged)
                    // {
                    //     timerDraw.Stop();
                    //     test_timer.Stop();
                    //     MetroMessageBox.Show(this, "\r\n\r\n" + "Optical switch write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //     return;
                    // }
                    // else
                    // {

                    //Thread.Sleep(TimeSpan.FromMinutes(1));//switch needs about 30s, test sets 60s
                    ////usb.Delay(60000);
                    //for (int i = 0; i < 20; i++)
                    //{
                    usb.SendData(foh100_state_command);
                    thread = new Thread(new ThreadStart(GetData_foh100_state0));
                    thread.Start();
                    usb.Delay(100);
                    //}

                    //  }


                    ////usb.SendData_two(switch_command2);  //EPON
                    //channelChanged = usb.ChangeChannel(switch_command2);
                    //if (!channelChanged)
                    //{
                    //    timerDraw.Stop();
                    //    test_timer.Stop();
                    //    MetroMessageBox.Show(this, "\r\n\r\n" + "Optical switch write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    //Thread.Sleep(TimeSpan.FromMinutes(1));//switch needs about 30s, test sets 60s
                    //usb.Delay(60000);
                    //for (int i = 0; i < 20; i++)
                    //{
                    //    usb.SendData(foh100_state_command);
                    //    thread = new Thread(new ThreadStart(GetData_foh100_state1));
                    //    thread.Start();
                    //    usb.Delay(500);
                    //}


                }
                catch
                {
                    usb.CloseCom();
                    ToggleControls(false);
                    MetroMessageBox.Show(this, "\r\n\r\n" + "Serial write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        public void GetData_foh100_state0()
        {
            String msg = "";

            Thread.Sleep(100);

            int i = 0;
            msg = usb.ReadData();

            if (msg.Contains("sys_power_flg")) // || msg.Contains( "onu_info.rx_lenth")
            {
                Action<int> action = (data) =>
                {
                    int start0 = msg.IndexOf("gpon_epon_display_flg");
                    int length0 = " = 1".Length;
                    String tmpValue0 = msg.Substring(start0 + 23, length0 - 1).Trim();

                    ponState = tmpValue0;
                    //judge autoSwitch OK?

                    //if (tmpValue0 == "0")
                    //{
                    //    g1rCount++;
                    //}
                    //else
                    //{
                    //    g1wCount++;
                    //}

                    String responseoutput = String.Empty;
                    responseoutput = msg;

                    string path = System.Windows.Forms.Application.StartupPath + "\\LogFile\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    string postPath = path + "FOH_LOG.txt";//path + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"
                    StreamWriter file = new StreamWriter(postPath, true);
                    file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff") + "        " + responseoutput);
                    file.Close();


                    // x1.Add(timerDrawI);

                    // y1.Add(float.Parse(tb_mcu_temperate.Text));
                    // timerDrawI++;
                    //refreshCartesianChart1();

                    // lbl_send_count.Text = "Count: " + sendCount++.ToString();
                };
                Invoke(action, i);
                i++;
                Thread.Sleep(200);
            }
        }
        private void foh100_state1()
        {
            if (isOpen)
            {
                try
                {
                    usb2.SendData(foh100_state_command);
                    thread = new Thread(new ThreadStart(GetData_foh100_state1));
                    thread.Start();
                    usb2.Delay(100);
                }
                catch
                {
                    usb2.CloseCom();
                    ToggleControls(false);
                    MetroMessageBox.Show(this, "\r\n\r\n" + "Serial write wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        public void GetData_foh100_state1()
        {
            String msg = "";

            Thread.Sleep(100);

            int i = 0;
            msg = usb2.ReadData();

            if (msg.Contains("sys_power_flg")) // || msg.Contains( "onu_info.rx_lenth")
            {
                Action<int> action = (data) =>
                {
                    int start0 = msg.IndexOf("gpon_epon_display_flg");
                    int length0 = " = 1".Length;
                    String tmpValue0 = msg.Substring(start0 + 23, length0 - 1).Trim();

                    ponState1 = tmpValue0;

                    String responseoutput = String.Empty;
                    responseoutput = msg;

                    string path = System.Windows.Forms.Application.StartupPath + "\\LogFile\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    string postPath = path + "FOH_LOG.txt";//path + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"
                    StreamWriter file = new StreamWriter(postPath, true);
                    file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff") + "        " + responseoutput);
                    file.Close();

                };
                Invoke(action, i);
                i++;
                Thread.Sleep(200);
            }
        }

        bool testStatus = false;
        private void testButton_Click(object sender, EventArgs e)
        {
            //if (manulCheckBox.CheckState == CheckState.Checked && portButton.Text == "Close")
            if(!testStatus)
            {
                f_timerDrawStart(); //start sample timer
                test_timer.Start();
                TimeCount = 0;
                testStatus = true;
            }
            else
            {
                timerDraw.Stop();
                test_timer.Stop();

                testStatus = false;
            }
            testButton.Text = testStatus ? "Stop" : "Start";

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (portFxCheckBox.Checked)
            {
                cartesianChart1.Series.Clear();// Values.Clear();

                osCount = 0;

                f1Count = 0;
                g1rCount = 0;
                g1wCount = 0;
                e1rCount = 0;
                e1wCount = 0;

                f2Count = 0;
                g2rCount = 0;
                g2wCount = 0;
                e2rCount = 0;
                e2wCount = 0;

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = "Count: ",

                    Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                    new ObservableValue(f2Count),
                    new ObservableValue(g2rCount),
                    new ObservableValue(g2wCount),
                    new ObservableValue(e2rCount),
                    new ObservableValue(e2wCount),
                },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " "
                });
            }
            else
            {
                cartesianChart1.Series.Clear();// Values.Clear();

                osCount = 0;

                f1Count = 0;
                g1rCount = 0;
                g1wCount = 0;
                e1rCount = 0;
                e1wCount = 0;

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = "Count: ",

                    Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " "
                });
            }
        }
        #endregion



        private void graphTestButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            { osCount++; }


            cartesianChart1.Series.Clear();// Values.Clear();

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "Count: ",

                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(osCount),
                    new ObservableValue(f1Count),
                    new ObservableValue(g1rCount),
                    new ObservableValue(g1wCount),
                    new ObservableValue(e1rCount),
                    new ObservableValue(e1wCount),
                    new ObservableValue(f2Count),
                    new ObservableValue(g2rCount),
                    new ObservableValue(g2wCount),
                    new ObservableValue(e2rCount),
                    new ObservableValue(e2wCount),
                },
                DataLabels = true,
                LabelPoint = point => point.Y + " "
            });

        }


    }

}
