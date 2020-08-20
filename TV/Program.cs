using System;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Television
    {
        private int currentChannel = 7; 
        private int currentVolume = 15;
        
        public void IncreaseVolume()
        {
            currentVolume++;
        }   
        public void DecreaseVolume()
        {
            currentVolume--;
        }   
        public int Volume()
        {
            return currentVolume;
        } 
        public void IncreaseChannel()
        {
            currentChannel++;
        }
        public void DecreaseChannel()
        {
            currentChannel--;
        }
        public int Channel()     
        {
            return currentChannel;
        }
    
    }
}
