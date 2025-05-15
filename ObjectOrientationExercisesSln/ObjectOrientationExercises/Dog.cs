
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Dog : Animal
    {
        public void ProtectsOwner()
        {
            Console.WriteLine("BITE");
        }

        public override void MakeNoise()
        {
            string fileName = "dog.mp3";

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
