using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreevIEW;
using static System.Windows.Forms.DataFormats;

namespace TreeView
{
    public partial class Form1 : Form
    {
        string treeAffiche = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LabelStatus.Text = "Exemple de treeView";
            InitializeTree();

        }
        private void InitializeTree()
        {
            // Add parent node
            TreeNode noeud = treeView1.Nodes.Add("Automobile");

            // Add child node
            TreeNode Fils = noeud.Nodes.Add("Boite de vitesses");
            Fils.Nodes.Add("1", "Arbre primaire").Nodes.Add("2", "Sychro 1ERE");
            TreeNode Fils2 = noeud.Nodes.Add("Moteur");
            Fils2.Nodes.Add(key: "M1", text: "Vilebrequin");

            // ajoute un noeud enfant sur un neode recherché
            treeView1.Nodes.Find("M1", true)[0].Nodes.Add("22", "pignon chaine distri");
            //============

            Fils2.Nodes.Add(key: "M2", text: "Bielle");

            // treeView1.Nodes.Find("M1", true)[0].Remove();
            treeView1.SelectedNode = treeView1.Nodes.Find(key: "M1", true)[0];
            treeView1.SelectedNode.Nodes.Add(" M112", "Coussinet");
            treeView1.ExpandAll();

            if (treeView1.Nodes.Find("M1", true)[0] != null)
            {
                // MessageBox.Show(treeView1.Nodes.Find("M1", true)[0].Text);
            }
        }

        /// <summary>
        /// Enregistre l'arbre sous forme de fichier binaire.
        /// </summary>
        /// <param name="tree"> nom de treeview</param>
        /// <param name="filename">Nom du fichier</param>
        private static void SaveTree(System.Windows.Forms.TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, tree.Nodes.Cast<TreeNode>().ToList());
            }
        }

        /// <summary>
        /// Rappelle les données d'un treeview enregistré dans un fichier binaire
        /// pour les mettre dans un treeview.
        /// </summary>
        /// <param name="tree"> nom du treeview</param>
        /// <param name="filename">nom du fichier</param>
        private static void LoadTree(System.Windows.Forms.TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);

                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                tree.Nodes.AddRange(nodeList);
            }
        }

        // sauvagarde  l'arbre
        private void button2_Click(object sender, EventArgs e)
        {
            SaveTree(treeView1, "FileSaveTreeview");
        }

        //rappel sauvegarde d'un arbre
        private void button3_Click(object sender, EventArgs e)
        {
            LoadTree(treeView2, "FileSaveTreeview");
        }



        private void buttonSuppressionNoeud_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        // Affichage du menu contectuel au clic droit sur TreView1
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
        }

        private void RenemmerLeNoeudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForDataDialog F2 = new ForDataDialog("Renomme Noeud", "Nouveau nom");
            F2.ShowDialog();
            treeView1.SelectedNode.Text = F2.data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  RenommeNoeud();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode.Checked = true;
            treeView1.SelectedNode.ForeColor = Color.Black;

            if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
            {
                this.LabelStatus.Text = "Le Noeud " + treeView1.SelectedNode.Name
                    + " dont le contenu est " + treeView1.SelectedNode.Text
                    + " possède un parent nommé :" + e.Node.Parent.Name
                    + " dont le contenu est " + e.Node.Parent.Text;
            }
            else
            {
                this.LabelStatus.Text = "Le Noeud " + treeView1.SelectedNode.Name + " n'a pas de parent.";
            }
        }

        private void supprimerLeNoeudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void insérerUnNoeudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsereNoeud FenInsertNode = new FormInsereNoeud();
            FenInsertNode.ShowDialog();
            treeView1.SelectedNode.Nodes.Add(FenInsertNode.key, FenInsertNode.designation);
        }

        private void propriétésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Nom : " + treeView1.SelectedNode.Name + "\n Contenu : "
                + treeView1.SelectedNode.Text + "\n Coché : " + treeView1.SelectedNode.Checked.ToString());

        }

        public void GetChildren(List<TreeNode> Nodes, TreeNode Node)
        {
            foreach (TreeNode thisNode in Node.Nodes)
            {
                Nodes.Add(thisNode);
                //   GetChildren(Nodes, thisNode);
                MessageBox.Show(Nodes.ToString());
            }
        }

        private void afficheLeParentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Texto;
            TreeNode tn = treeView1.SelectedNode;
            if (tn.Parent != null && tn.Parent.GetType() == typeof(TreeNode))
            {
                Texto = "Le Noeud " + treeView1.SelectedNode.Name
                   + "\n dont le contenu est " + treeView1.SelectedNode.Text
                   + "\n possède un parent nommé :" + tn.Parent.Name
                   + "\n dont le contenu est " + tn.Parent.Text;
            }
            else
            {
                Texto = "pas de parent!";

            }
            MessageBox.Show(Texto);
        }

        private void AfficheEnfants()
        {
            string textAffiche = string.Empty;
            TreeNodeCollection nodes = treeView1.SelectedNode.Nodes;
            foreach (TreeNode N in nodes)
            {
                //  MessageBox.Show(N.Text);
                textAffiche += N.Text + "  ";
            }
            MessageBox.Show(textAffiche);
        }

        private void afficheEnfantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficheEnfants();
        }

        // Affiche le contenu de l'arbre
        private void AfficheAbre(TreeNode workingNode)
        {
            foreach (TreeNode tn in workingNode.Nodes)
            {
                treeAffiche += tn.Text + "\n";
                AfficheAbre(tn);
            }
        }

        // trouve le noeud racine
        private TreeNode FindRootNode(TreeNode treeNode)
        {
            while (treeNode.Parent != null)
            {
                treeNode = treeNode.Parent;
            }
            return treeNode;
        }

        // affiche le contenu de l'arbre
        private void btSeeTree_Click(object sender, EventArgs e)
        {
            TreeNode racine = FindRootNode(treeView1.SelectedNode);
            treeAffiche = " La Racine est " + racine.Text + "\n\n";
            AfficheAbre(racine);
            MessageBox.Show(treeAffiche);
        }

        //  Menu contextuel : recherche d'un noeud par sa clé
        private void trouveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForDataDialog F2 = new ForDataDialog("Recherche par clé", "Clé");
            F2.ShowDialog();
            string toSearch = F2.data;
            bool ok = SearchNodeByKeyRecursivly(treeView1.Nodes, toSearch);
            if (ok)
            {
                MessageBox.Show("Pas de noeud trouvé par cette clé", "Recherche de noeud par Clé", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            };
            treeView1.Refresh();
        }

        private void trouveToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            // trouveToolStripMenuItem.Text = "Trouve Noeud de clé " + tbCle.Text;
        }

        private bool SearchNodeByKeyRecursivly(IEnumerable nodes, string searchFor)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Name == searchFor)
                {
                    treeView1.SelectedNode = node;
                    node.BackColor = Color.Yellow;
                    treeView1.Refresh();
                }
                else
                {
                    node.BackColor = Color.White;
                }
                if (SearchNodeByKeyRecursivly(node.Nodes, searchFor))
                    return true;
            }
            return false;
        }

        private bool SearchNodeByValueRecursivly(IEnumerable nodes, string searchFor)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == searchFor)
                {
                    treeView1.SelectedNode = node;
                    node.BackColor = Color.Aqua;
                    treeView1.Refresh();
                }
                else
                {
                    node.BackColor = Color.White;
                }
                if (SearchNodeByValueRecursivly(node.Nodes, searchFor))
                    return true;
            }
            return false;
        }

        private void trouveNoeudContenantToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //     trouveNoeudContenantToolStripMenuItem.Text = "Trouve Noeud contenant  " + tbCle.Text;
        }

        private void trouveNoeudContenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForDataDialog F2 = new ForDataDialog("Recherche par désignation", "Noeud");
            F2.ShowDialog();
            string toSearch = F2.data;
            if (SearchNodeByValueRecursivly(treeView1.Nodes, toSearch))
            {
                MessageBox.Show("Pas de noeud trouvé", "Recherche de noeud par contenu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            treeView1.Refresh();
        }

        // sauvegarde arbre sur DD
        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Tree File|*.tree";
            saveFileDialog1.Title = "Enregistrement de l'arbre";
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);
            {
                string treeFilename = saveFileDialog1.FileName;
            };

            using (Stream file = File.Open(saveFileDialog1.FileName, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, treeView1.Nodes.Cast<TreeNode>().ToList());
                this.LabelStatus.Text = "Fichier " + saveFileDialog1.FileName + " enregistré.";
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tree File|*.tree";
            openFileDialog.Title = "Enregistrement de l'arbre";
            openFileDialog.ShowDialog();
            string treeFilename = openFileDialog.FileName;
            using (Stream file = File.Open(treeFilename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);
                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                treeView1.Nodes.AddRange(nodeList);
            }
        }

        private void btTreeFromTextFile_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();
            TreeNode racine = treeView1.Nodes.Add(string.Empty, "RACINE");
            treeView1.SelectedNode = racine;
            treeView1.SelectedNode.BackColor = Color.AliceBlue;

            // Pour tous les mots (une ligne = 1 mot).
            using (StreamReader sr = File.OpenText(@"E:\Github\TreeView\bin\Debug\DataTree.txt"))
            {
                //char car;
                string discriminator = "";
                string s = "";
                string key = "";
                string valeur = "";
                Color nodeColor = Color.White;

                // tant que la fin du fichier texte n'est pa atteinte.               
                while ((s = sr.ReadLine()) != null)
                {
                    // pour chaque lettre du mot.
                    for (int i = 0; i < s.Length; i++)
                    {
                        key = s[i] + discriminator;
                        valeur = s[i].ToString();
                        if (i == s.Length - 1)
                        {
                            discriminator = "FM";
                            nodeColor = Color.Yellow;
                        }
                        else
                        {
                            discriminator = "PM";
                            nodeColor = Color.White;
                        }

                        // ajout noeud
                        TreeNode newNode = treeView1.SelectedNode.Nodes.Add(key, valeur);
                        treeView1.SelectedNode = newNode;
                        treeView1.SelectedNode.BackColor = nodeColor;
                        treeView1.SelectedNode = newNode;

                        //si fin de mot  alors le noeud courent est la racine
                        if (i == s.Length - 1)
                        {
                            treeView1.SelectedNode = racine;
                        }
                    }
                }
                this.Refresh();
                treeView1.ExpandAll();
            }
        }
    }
}
