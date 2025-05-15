using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Eagle : Animal
    {
        public override void MakeNoise()
        {
            string fileName = "eagle.mp3";

            using (var audioFile = new AudioFileReader(fileName))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }

      
    }
}
