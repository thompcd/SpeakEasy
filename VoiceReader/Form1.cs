using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace VoiceReader
{
    public partial class SpeakEasy : Form
    {
        public int voiceRate;
        public SpeakEasy()
        {
            InitializeComponent();
            int voiceRate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        speakTxt.Text.Say(voiceRateUpDown.Value);
        }
    }
    public static class MakeStringsTalk
    {
        public static void Say(this string s, decimal rate)
        {
            SpVoice voice = new SpVoiceClass();
            ISpeechObjectTokens tokens = voice.GetVoices();
            voice.Rate = (int)rate;
            voice.Volume = 100;
            voice.Voice = tokens.Item(0);
            voice.Speak(s, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}
