using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RPG.ExternalClasses;

namespace RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected List<Object> TLista;
        private Engine Engine;
        public MainWindow()
        {
            
            InitializeComponent();
            Engine = new Engine();
            TLista = Engine.GetObj();
            UpdateLabels();
        }

        private void AddSkill_Click(object sender, RoutedEventArgs e)   //działa
        {
            var btn = (Button)e.OriginalSource;
            (TLista[0] as Player).DistributeSkillPoint(btn.Tag.ToString());

            UpdateLabels();
        }               //distribute skillpoint

        private void Akcja_Click(object sender, RoutedEventArgs e)
        {
            //if ((TLista[0] as Player).TakeDamage(10)) { }   Atak działa ok
            (TLista[0] as Player).LvlUp(43);     // lvlUp działa

            UpdateLabels();
        }
        private void UpdateLabels()
        {
            numAgil.Content = (TLista[0] as Player).GetAgi().ToString();
            numDex.Content = (TLista[0] as Player).GetDex().ToString();
            numEndu.Content = (TLista[0] as Player).GetEndur().ToString();
            numIntel.Content = (TLista[0] as Player).GetInt().ToString();
            numKnow.Content = (TLista[0] as Player).GetKnow().ToString();
            numLuck.Content = (TLista[0] as Player).GetLuck().ToString();
            numSpeed.Content = (TLista[0] as Player).GetSpeed().ToString();
            numStam.Content = (TLista[0] as Player).GetStam().ToString();
            numStr.Content = (TLista[0] as Player).GetStr().ToString();
            numWill.Content = (TLista[0] as Player).GetWill().ToString();
            numLvl.Content = (TLista[0] as Player).GetLvl().ToString();
            numHP.Content = (TLista[0] as Player).GetHP().ToString()+"/"+ (TLista[0] as Player).GetMaxHP().ToString(); 
            numMP.Content = (TLista[0] as Player).GetMP().ToString()+"/"+ (TLista[0] as Player).GetMaxMP().ToString();
            HPBar.Maximum = (TLista[0] as Player).GetMaxHP();
            HPBar.Value = (TLista[0] as Player).GetHP();
            MPBar.Maximum = (TLista[0] as Player).GetMaxMP();
            MPBar.Value = (TLista[0] as Player).GetMP();
            numSkillPoints.Content = (TLista[0] as Player).GetSkillPoints().ToString();
            numDef.Content = (TLista[0] as Player).GetDef().ToString();
            numAtak.Content = (TLista[0] as Player).GetAtak().ToString();
            numExp.Content = (TLista[0] as Player).GetExp().ToString()+"/"+ (TLista[0] as Player).GetMaxExp().ToString();
            ExpBar.Maximum = (TLista[0] as Player).GetMaxExp();
            ExpBar.Value = (TLista[0] as Player).GetExp();
            if ((TLista[0] as Player).GetSkillPoints() > 0)
            {
                AddSkillAgil.Visibility = Visibility.Visible;
                AddSkillDex.Visibility = Visibility.Visible;
                AddSkillEndu.Visibility = Visibility.Visible;
                AddSkillIntel.Visibility = Visibility.Visible;
                AddSkillKnow.Visibility = Visibility.Visible;
                AddSkillLuck.Visibility = Visibility.Visible;
                AddSkillSpeed.Visibility = Visibility.Visible;
                AddSkillStr.Visibility = Visibility.Visible;
                AddSkillWill.Visibility = Visibility.Visible;
            }
            else
            {
                AddSkillAgil.Visibility = Visibility.Collapsed;
                AddSkillDex.Visibility = Visibility.Collapsed;
                AddSkillEndu.Visibility = Visibility.Collapsed;
                AddSkillIntel.Visibility = Visibility.Collapsed;
                AddSkillKnow.Visibility = Visibility.Collapsed;
                AddSkillLuck.Visibility = Visibility.Collapsed;
                AddSkillSpeed.Visibility = Visibility.Collapsed;
                AddSkillStr.Visibility = Visibility.Collapsed;
                AddSkillWill.Visibility = Visibility.Collapsed;
            }   //show/hide +1 skillpoints distribute buttons
        }


    }
}
