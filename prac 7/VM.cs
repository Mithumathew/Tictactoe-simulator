using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace prac_7
{
    class VM : INotifyPropertyChanged
    {   //Properties
        private string square1;
        public string Square1
        { get { return square1; }
          set { square1 = value;OnPropertyChanged(); }
        }
        private string square2;
        public string Square2
        {
            get { return square2; }
            set { square2 = value; OnPropertyChanged(); }
        }
        private string square3;
        public string Square3
        {
            get { return square3; }
            set { square3 = value; OnPropertyChanged(); }
        }
        private string square4;
        public string Square4
        {
            get { return square4; }
            set { square4 = value; OnPropertyChanged(); }
        }
        private string square5;
        public string Square5
        {
            get { return square5; }
            set { square5 = value; OnPropertyChanged(); }
        }
        private string square6;
        public string Square6
        {
            get { return square6; }
            set { square6 = value; OnPropertyChanged(); }
        }
        private string square7;
        public string Square7
        {
            get { return square7; }
            set { square7 = value; OnPropertyChanged(); }
        }
        private string square8;
        public string Square8
        {
            get { return square8; }
            set { square8 = value; OnPropertyChanged(); }
        }
        private string square9;
        public string Square9
        {
            get { return square9; }
            set { square9 = value; OnPropertyChanged(); }
        }
        public void Gridgenerator()
        {
            int[,] grid = new int[3, 3];
            string[,] lettergrid = new string[3, 3];
            Random r = new Random();
            for(int i=0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    grid[i, j] = r.Next(0, 2);
                    if(grid[i,j]==0)
                    { lettergrid[i, j] = "O"; }
                    if(grid[i,j]==1)
                    { lettergrid[i, j] = "X"; }
                 }
            }
            square1 = lettergrid[0, 0];
            square2 = lettergrid[0, 1];
            square3 = lettergrid[0, 2];
            square4 = lettergrid[1, 0];
            square5 = lettergrid[1, 1];
            square6 = lettergrid[1, 2];
            square7 = lettergrid[2, 0];
            square8 = lettergrid[2, 1];
            square9 = lettergrid[2, 2];

            }
        public void Checkwinner()
        {
           string winner = "";
            if((Square1=="X"&& Square2=="X" && Square3=="X")|| (Square4 == "X" && Square5 == "X" && Square6 == "X")|| (Square7 == "X" && Square8 == "X" && Square9 == "X")
                || (Square1 == "X" && Square4 == "X" && Square7 == "X")|| (Square2 == "X" && Square5 == "X" && Square7 == "X")|| (Square3 == "X" && Square6 == "X" && Square9 == "X"))
            { winner = "X is the winner";
                MessageBox.Show(winner);
            }
            if ((Square1 == "O" && Square2 == "O" && Square3 == "O") || (Square4 == "O" && Square5 == "O" && Square6 == "O") || (Square7 == "O" && Square8 == "O" && Square9 == "O")
                || (Square1 == "O" && Square4 == "O" && Square7 == "O") || (Square2 == "O" && Square5 == "O" && Square7 == "O") || (Square3 == "O" && Square6 == "O" && Square9 == "O"))
            {
                winner = "O is the winner";
                MessageBox.Show(winner);
           
            if (winner=="")
                { MessageBox.Show("No winner"); } 

            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string caller = null)
        {
            // make sure only to call this if the value actually changes

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
