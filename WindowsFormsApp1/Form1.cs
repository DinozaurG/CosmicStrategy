using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Planet[] planets = new Planet[1];
        int pIndex;
        int bIndex;
        public Form1()
        {
            InitializeComponent();
            listOfPlanets.SelectedIndexChanged += listOfPlanets_SelectedIndexChanged;
        }
        private void buttonPlanet_Click(object sender, EventArgs e)
        {
            Planet planet = new Planet();
            planet.m_name = "Планета";
            planet.resources = 1000;
            planets[planets.Length - 1] = planet;
            listOfPlanets.Items.Insert(planets.Length - 1, planet);
            listOfPlanets.DisplayMember = "name";
            Array.Resize(ref planets, planets.Length + 1);
        }
        private void listOfPlanets_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOfColonies.Items.Clear();
            pIndex = listOfPlanets.SelectedIndex;
            if(pIndex > -1)
            if (planets[pIndex].builds.Length >= 1 && planets[pIndex].builds[0] != null)
            {
                listOfColonies.Items.AddRange(planets[pIndex].builds);
            }
        }
        private void buttonStartColony_Click(object sender, EventArgs e)
        {
            if (planets[pIndex].builds.Length == 0)
            {
                HQBuilding hQ = new HQBuilding();
                hQ.m_name = "Штаб";
                listOfColonies.Items.Insert(planets[pIndex].builds.Length, hQ);
                listOfColonies.DisplayMember = "name";
                Array.Resize(ref planets[pIndex].builds, planets[pIndex].builds.Length + 1);
                planets[pIndex].builds[0] = hQ;
            }
        }
        private void listOfColonies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planets[pIndex].builds.Length > 1 && planets[pIndex].builds[1] != null)
            {
                
            }
        }
        private void buttonBuildResBuilding_Click(object sender, EventArgs e)
        {
            if(planets[pIndex].builds.Length == 0)
            {
                MessageBox.Show("Чтобы построить здания, нужен штаб!","Вы не построили штаб!");
            }
            else
            {
                ResourceBuilding resB = new ResourceBuilding();
                resB.m_name = "Шахта";
                listOfColonies.Items.Insert(planets[pIndex].builds.Length, resB);
                listOfColonies.DisplayMember = "name";
                Array.Resize(ref planets[pIndex].builds, planets[pIndex].builds.Length + 1);
                planets[pIndex].builds[planets[pIndex].builds.Length - 1] = resB;
            }
        }
        private void buttonBuildUnitBuilding_Click(object sender, EventArgs e)
        {
            if (planets[pIndex].builds.Length == 0)
            {
                MessageBox.Show("Чтобы построить здания, нужен штаб!", "Вы не построили штаб!");
            }
            else
            {
                UnitBuilding unitB = new UnitBuilding();
                unitB.m_name = "Домик";
                listOfColonies.Items.Insert(planets[pIndex].builds.Length, unitB);
                listOfColonies.DisplayMember = "name";
                Array.Resize(ref planets[pIndex].builds, planets[pIndex].builds.Length + 1);
                planets[pIndex].builds[planets[pIndex].builds.Length - 1] = unitB;
            }
        }
    }
}
