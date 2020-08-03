using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            int ivideodevicecount = 0;
            int iaudiodevicecount = 0;
            int i = 0;
            ivideodevicecount = axVideoChatSender.GetVideoDeviceCount();
            for (i = 0; i < ivideodevicecount; i++)
                comboBoxVideoDevice.Items.Add(axVideoChatSender.GetVideoDeviceName((short)i));

            if (comboBoxVideoDevice.Items.Count > 0)
                comboBoxVideoDevice.SelectedIndex = 0;

            iaudiodevicecount = axVideoChatSender.GetAudioDeviceCount();

            for (i = 0; i < iaudiodevicecount; i++)
                comboBoxAudioDevice.Items.Add(axVideoChatSender.GetAudioDeviceName((short)i));
            if (comboBoxAudioDevice.Items.Count > 0)
                comboBoxAudioDevice.SelectedIndex = 0;

            comboBoxVideoFormat.Items.Add("160x120");
            comboBoxVideoFormat.Items.Add("176x144");
            comboBoxVideoFormat.Items.Add("320x240");
            comboBoxVideoFormat.Items.Add("352x288");
            comboBoxVideoFormat.Items.Add("640x480");
            comboBoxVideoFormat.Items.Add("1280x720");
            comboBoxVideoFormat.SelectedIndex = 4;

            comboBoxAudioComplex.Items.Add("0");
            comboBoxAudioComplex.Items.Add("1");
            comboBoxAudioComplex.Items.Add("2");
            comboBoxAudioComplex.Items.Add("3");
            comboBoxAudioComplex.SelectedIndex = 0;

            for (i = 0; i <= 10; i++)
                comboBoxAudioQuality.Items.Add(i.ToString());

            comboBoxAudioQuality.SelectedIndex = 8;
        }

       

        private void buttonDisConnect_Click(object sender, RoutedEventArgs e)
        {
            axVideoChatSender.Disconnect();
        }

        private void buttonConnect_Click(object sender, RoutedEventArgs e)
        {
            axVideoChatSender.VideoDevice = (short)comboBoxVideoDevice.SelectedIndex;

            axVideoChatSender.AudioDevice = (short)comboBoxAudioDevice.SelectedIndex;


            axVideoChatSender.VideoFormat = (short)comboBoxVideoFormat.SelectedIndex;
            axVideoChatSender.FrameRate = Convert.ToInt32(txtFrameRate.Text, 10);
            axVideoChatSender.VideoBitrate = Convert.ToInt32(txtVideoBitrate.Text, 10);
            axVideoChatSender.AudioComplexity = (short)comboBoxAudioComplex.SelectedIndex;
            axVideoChatSender.AudioQuality = (short)comboBoxAudioQuality.SelectedIndex;
            axVideoChatSender.SendAudioStream = (bool)checkBoxSendAudio.IsChecked;
            axVideoChatSender.SendVideoStream = (bool)checkBoxSendVideo.IsChecked;

            axVideoChatSender.ConferenceNumber = 0;
            axVideoChatSender.ConferenceUserID = 0;

            int iResult = axVideoChatSender.Connect(txtStreamToIP.Text, Convert.ToInt32(txtPortno.Text, 10));

        }
    }
}
