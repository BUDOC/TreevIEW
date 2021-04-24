using System;
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

namespace TreevIEW
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
      Fils2.Nodes.Add(key: "M2", text: "Bielle");
      // treeView1.Nodes.Find("M1", true)[0].Remove();
      treeView1.SelectedNode = treeView1.Nodes.Find(key: "M1", true)[0];
      treeView1.SelectedNode.Nodes.Add(" M112", "Coussinet");
      treeView1.ExpandAll();
    }

    /// <summary>
    /// Enregistre l'arbre sous forme de fichier binaire.
    /// </summary>
    /// <param name="tree"> nom de treeview</param>
    /// <param name="filename">Nom du fichier</param>
    private static void SaveTree(TreeView tree, string filename)
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
    private static void LoadTree(TreeView tree, string filename)
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
  }
}
