using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public abstract class Object
    {
        public void getInformation()
        {

        }
        public void getMethods()
        {

        }
    }
    public abstract class Ship : Object
    {
        static private float shipMoveSpeed;
        void shipping()
        {

        }
    }
    public abstract class Unit : Object
    {
        private float moveSpeed;
        private void move()
        {

        }
    }
    public abstract class Building : Object
    {
        private int price;
    }
    public class Planet : Object
    {
        public string m_name;
        public string name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public int resources;
        public Building[] builds = new Building[0];
        public void createHQBuilding()
        {

        }
    }
    public class Couriership : Ship
    {
        private int courieredRes = 0;
        static private int maxOfCourieredRes;
        void resIn()
        {

        }
        private void resOut()
        {

        }
    }
    public class Unitship : Ship
    {
        private int unitsIn = 0;
        static private int maxOfUnitsIn;
        void addUnit()
        {

        }
        private void deleteUnit()
        {

        }
    }
    public class MinerUnit : Unit
    {
        private int pickedRes;
        static private int maxOfPickedRes;
        private void getRes()
        {

        }
        private void outRes()
        {

        }
    }
    public class BuilderUnit : Unit
    {
        private void createBuilding()
        {

        }
    }
    public class HQBuilding : Building
    {
        public string m_name;
        public string name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private void createBuilder()
        {

        }
    }
    public class ResourceBuilding : Building
    {
        public string m_name;
        public string name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private int stashedRes = 0;
        static private int maxOfStashedRes;
        void stashRes()
        {

        }
        void deStashRes()
        {

        }
    }
    public class UnitBuilding : Building
    {
        public string m_name;
        public string name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private void createUnit()
        {

        }
    }

}
