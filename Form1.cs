﻿using System;
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
using static System.Windows.Forms.DataFormats;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SaveTree(treeView1, "FileSaveTreeview");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadTree(treeView2, "FileSaveTreeview");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBoxCle.Text, textBoxDesignation.Text);
        }

        private void buttonSuppressionNoeud_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //  contextMenuStrip1.Show();
        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
        }

        private void RenemmerLeNoeudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenommeNoeud();
        }

        private void RenommeNoeud()
        {
            this.textBox1.BackColor = Color.Coral;
            string message = "Voulez vous changer en :" + this.textBox1.Text + " ?";
            string caption = "Changement de désignation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            { treeView1.SelectedNode.Text = textBox1.Text; }
            this.textBox1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RenommeNoeud();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode.Checked = true;
            treeView1.SelectedNode.ForeColor = Color.Black;

            if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
            {
                this.Text = "Le Noeud " + treeView1.SelectedNode.Name
                    + "\n dont le contenu est " + treeView1.SelectedNode.Text
                    + "\n possède un parent nommé :" + e.Node.Parent.Name
                    + "\n dont le contenu est " + e.Node.Parent.Text;
            }
            else
            {
                this.Text = "Le Noeud " + treeView1.SelectedNode.Name + " n'a pas de parent.";
            }
        }

        private void supprimerLeNoeudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void insérerUnNoeudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBoxCle.Text, textBoxDesignation.Text);
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
            TreeNode tn = treeView1.SelectedNode;
            if (tn.Parent != null && tn.Parent.GetType() == typeof(TreeNode))
            {
                string Text = "Le Noeud " + treeView1.SelectedNode.Name
                    + "\n dont le contenu est " + treeView1.SelectedNode.Text
                    + "\n possède un parent nommé :" + tn.Parent.Name
                    + "\n dont le contenu est " + tn.Parent.Text;
            }
            else
            {
                Text = "pas de parent!";

            }
            MessageBox.Show(Text);
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

        string treeAffiche = string.Empty;
        private void AfficheAbre(TreeNode workingNode)
        {
            foreach (TreeNode tn in workingNode.Nodes)
            {
                treeAffiche += tn.Text + "\n";
                AfficheAbre(tn);
            }
        }

        private TreeNode FindRootNode(TreeNode treeNode)
        {
            while (treeNode.Parent != null)
            {
                treeNode = treeNode.Parent;
            }
            return treeNode;
        }

        private void btSeeTree_Click(object sender, EventArgs e)
        {
            TreeNode racine = FindRootNode(treeView1.SelectedNode);
            treeAffiche = " La Racinne est " + racine.Text + "\n\n";
            AfficheAbre(racine);
            MessageBox.Show(treeAffiche);           
        }

        private void trouveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if (  treeView1.Nodes.Find("M1", true)== null)
            {
                MessageBox.Show("M1 noeud trouvé");               
            }
          else
            {
                MessageBox.Show("M1 trouvé \n" + treeView1.Nodes.Find("M1", true).First());
            }

        }
    }
}
