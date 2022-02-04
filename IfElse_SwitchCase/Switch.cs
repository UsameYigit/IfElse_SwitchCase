using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse_SwitchCase
{
    public partial class Switch : Form
    {
        string search;

        public Switch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text.ToLower();
            if (rdbtnGods.Checked)
            {
                MessageBox.Show(SelectedTheme());
            }
            else
            {
                SelectedTheme(search);
            }
            
        }

        void SelectedTheme(string search)
        {
            switch (search)
            {
                case "malkoc oglu":
                case "battal gazi":
                case "lokman hekim":
                case "alparslan":
                    MessageBox.Show("The hero you choose is from Turkey. You can write \"Turkey\" to see other heroes from Turkey.");
                    break;
                case "achilles":
                case "hector":
                case "odysseus":
                case "jason":
                    MessageBox.Show("The hero you choose is from Greece. You can write \"Greece\" to see other heroes from Greece.");
                    break;
                case "arthur":
                case "merlin":
                case "beowulf":
                case "robin hood":
                    MessageBox.Show("The hero you choose is from England. You can write \"England\" to see other heroes from England.");
                    break;
                case "lu bu":
                case "guan yu":
                case "mulan":
                case "han xin":
                    MessageBox.Show("The hero you choose is from China. You can write \"China\" to see other heroes from China.");
                    break;
                case "turkey":
                    MessageBox.Show("Well known heroes from Turkey are: \nMalkoç Oğlu \nBattal Gazi \nLokman Hekim \nAlparslan");
                    break;
                case "greece":
                    MessageBox.Show("Well known heroes from Greece are: \nAchilles \nHector \nOdysseus \nJason");
                    break;
                case "england":
                    MessageBox.Show("Well known heroes from England are: \nArthur \nMerlin \nBeowulf \nRobin Hood");
                    break;
                case "china":
                    MessageBox.Show("Well known heroes from China are: \nLu Bu \nGuan Yu \nMulan \nHan Xin");
                    break;
                default:
                    break;
            }
        }

        string SelectedTheme()
        {
            switch (search)
            {
                case "zeus":
                case "hades":
                case "posedion":
                case "heracles":
                    return "The God you wrote is a member of Greek Gods you can Search \"Greek\" to get more information about them.";
                    break;
                case "odin":
                case "thor":
                case "loki":
                case "baldur":
                    return "The God you wrote is a member of Norse Gods you can Search \"Norse\" to get more information about them.";
                    break;
                case "osiris":
                case "ra":
                case "set":
                case "isis":
                    return "The God you wrote is a member of Egyptian Gods you can Search \"Egyptian\" to get more information about them.";
                    break;
                case "shinigami":
                case "budha":
                case "kayra":
                case "brahma":
                    return "The God you wrote is a member of Other Gods we included in this archive you can Search \"Other\" to get more information about them.";
                    break;
                case "greek":
                    return "Greek mythology is the body of myths originally told by the ancient Greeks, and a genre of Ancient Greek folklore. These stories concern the origin and nature of the world, the lives and activities of deities, heroes, and mythological creatures, and the origins and significance of the ancient Greeks' own cult and ritual practices. Modern scholars study the myths to shed light on the religious and political institutions of ancient Greece, and to better understand the nature of myth-making itself.\n Zeus \n Posedion \n Hades \n Heracles";
                    break;
                case "norse":
                    return "Norse or Scandinavian mythology is the body of myths of the North Germanic peoples, stemming from Norse paganism and continuing after the Christianization of Scandinavia, and into the Scandinavian folklore of the modern period. The northernmost extension of Germanic mythology and stemming from Proto-Germanic folklore, Norse mythology consists of tales of various deities, beings, and heroes derived from numerous sources from both before and after the pagan period, including medieval manuscripts, archaeological representations, and folk tradition.\n Odin \n Thor \n Loki \n Baldur";
                    break;
                case "egyptian":
                    return "Over the course of Egyptian history hundreds of gods and goddesses were worshipped. The characteristics of individual gods could be hard to pin down. Most had a principle association (for example, with the sun or the underworld) and form. But these could change over time as gods rose and fell in importance and evolved in ways that corresponded to developments in Egyptian society.\n Osiris \n Ra \n Set \n Isis";
                    break;
                case "other":
                    return "The other Gods we included here are part of other mythologies such as Turkic, Chinise, Japanese, Indian.\n Shinigami \n Budha \n Kayra \n Brahma";
                    break;
                default:
                    return "In he presence of Gods, your words are meaningless here. So please write a word more meaningful here.";
                    break;
            }
        }


    }
}
