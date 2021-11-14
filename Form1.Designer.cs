
namespace TreeView
{
  partial class Form1
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerLeNoeudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insérerUnNoeudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renimmerLeNoeudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficheLeParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficheEnfantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btChangeNodeName = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSaveTreeview = new System.Windows.Forms.Button();
            this.bt_GetBackTreeview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCle = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.buttonInsertionNoeud = new System.Windows.Forms.Button();
            this.buttonSuppressionNoeud = new System.Windows.Forms.Button();
            this.btSeeTree = new System.Windows.Forms.Button();
            this.trouveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(21, 42);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(296, 386);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerLeNoeudToolStripMenuItem,
            this.insérerUnNoeudToolStripMenuItem,
            this.renimmerLeNoeudToolStripMenuItem,
            this.propriétésToolStripMenuItem,
            this.afficheLeParentToolStripMenuItem,
            this.afficheEnfantsToolStripMenuItem,
            this.trouveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 200);
            // 
            // supprimerLeNoeudToolStripMenuItem
            // 
            this.supprimerLeNoeudToolStripMenuItem.Name = "supprimerLeNoeudToolStripMenuItem";
            this.supprimerLeNoeudToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.supprimerLeNoeudToolStripMenuItem.Text = "Supprimer le noeud";
            this.supprimerLeNoeudToolStripMenuItem.Click += new System.EventHandler(this.supprimerLeNoeudToolStripMenuItem_Click);
            // 
            // insérerUnNoeudToolStripMenuItem
            // 
            this.insérerUnNoeudToolStripMenuItem.Name = "insérerUnNoeudToolStripMenuItem";
            this.insérerUnNoeudToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.insérerUnNoeudToolStripMenuItem.Text = "Insérer un noeud";
            this.insérerUnNoeudToolStripMenuItem.Click += new System.EventHandler(this.insérerUnNoeudToolStripMenuItem_Click);
            // 
            // renimmerLeNoeudToolStripMenuItem
            // 
            this.renimmerLeNoeudToolStripMenuItem.Name = "renimmerLeNoeudToolStripMenuItem";
            this.renimmerLeNoeudToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.renimmerLeNoeudToolStripMenuItem.Text = "Renommer le noeud";
            this.renimmerLeNoeudToolStripMenuItem.Click += new System.EventHandler(this.RenemmerLeNoeudToolStripMenuItem_Click);
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            this.propriétésToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.propriétésToolStripMenuItem.Text = "Propriétés";
            this.propriétésToolStripMenuItem.Click += new System.EventHandler(this.propriétésToolStripMenuItem_Click);
            // 
            // afficheLeParentToolStripMenuItem
            // 
            this.afficheLeParentToolStripMenuItem.Name = "afficheLeParentToolStripMenuItem";
            this.afficheLeParentToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.afficheLeParentToolStripMenuItem.Text = "Affiche le parent";
            this.afficheLeParentToolStripMenuItem.Click += new System.EventHandler(this.afficheLeParentToolStripMenuItem_Click);
            // 
            // afficheEnfantsToolStripMenuItem
            // 
            this.afficheEnfantsToolStripMenuItem.Name = "afficheEnfantsToolStripMenuItem";
            this.afficheEnfantsToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.afficheEnfantsToolStripMenuItem.Text = "Affiche enfants";
            this.afficheEnfantsToolStripMenuItem.Click += new System.EventHandler(this.afficheEnfantsToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(681, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Nouveau nom";
            // 
            // btChangeNodeName
            // 
            this.btChangeNodeName.BackColor = System.Drawing.Color.AliceBlue;
            this.btChangeNodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeNodeName.Location = new System.Drawing.Point(681, 83);
            this.btChangeNodeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChangeNodeName.Name = "btChangeNodeName";
            this.btChangeNodeName.Size = new System.Drawing.Size(195, 62);
            this.btChangeNodeName.TabIndex = 2;
            this.btChangeNodeName.Text = "Renomme avec le contenu du dessus";
            this.btChangeNodeName.UseVisualStyleBackColor = false;
            this.btChangeNodeName.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.Info;
            this.treeView2.Location = new System.Drawing.Point(349, 42);
            this.treeView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(255, 386);
            this.treeView2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Treeview1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Treeview2";
            // 
            // btSaveTreeview
            // 
            this.btSaveTreeview.Location = new System.Drawing.Point(57, 437);
            this.btSaveTreeview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaveTreeview.Name = "btSaveTreeview";
            this.btSaveTreeview.Size = new System.Drawing.Size(195, 23);
            this.btSaveTreeview.TabIndex = 6;
            this.btSaveTreeview.Text = "Enregistre Treeview1";
            this.btSaveTreeview.UseVisualStyleBackColor = true;
            this.btSaveTreeview.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_GetBackTreeview
            // 
            this.bt_GetBackTreeview.Location = new System.Drawing.Point(349, 437);
            this.bt_GetBackTreeview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_GetBackTreeview.Name = "bt_GetBackTreeview";
            this.bt_GetBackTreeview.Size = new System.Drawing.Size(243, 23);
            this.bt_GetBackTreeview.TabIndex = 7;
            this.bt_GetBackTreeview.Text = "Rappel fichier dans treeView2";
            this.bt_GetBackTreeview.UseVisualStyleBackColor = true;
            this.bt_GetBackTreeview.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Clé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Désignation";
            // 
            // textBoxCle
            // 
            this.textBoxCle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCle.Location = new System.Drawing.Point(691, 274);
            this.textBoxCle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCle.Name = "textBoxCle";
            this.textBoxCle.Size = new System.Drawing.Size(193, 22);
            this.textBoxCle.TabIndex = 10;
            this.textBoxCle.Text = "Key";
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxDesignation.Location = new System.Drawing.Point(691, 325);
            this.textBoxDesignation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(193, 22);
            this.textBoxDesignation.TabIndex = 11;
            this.textBoxDesignation.Text = "D";
            // 
            // buttonInsertionNoeud
            // 
            this.buttonInsertionNoeud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertionNoeud.ForeColor = System.Drawing.Color.Green;
            this.buttonInsertionNoeud.Location = new System.Drawing.Point(691, 353);
            this.buttonInsertionNoeud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertionNoeud.Name = "buttonInsertionNoeud";
            this.buttonInsertionNoeud.Size = new System.Drawing.Size(195, 43);
            this.buttonInsertionNoeud.TabIndex = 12;
            this.buttonInsertionNoeud.Text = "Insère noeud avec données ci-dessus";
            this.buttonInsertionNoeud.UseVisualStyleBackColor = true;
            this.buttonInsertionNoeud.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSuppressionNoeud
            // 
            this.buttonSuppressionNoeud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuppressionNoeud.ForeColor = System.Drawing.Color.Red;
            this.buttonSuppressionNoeud.Location = new System.Drawing.Point(689, 169);
            this.buttonSuppressionNoeud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSuppressionNoeud.Name = "buttonSuppressionNoeud";
            this.buttonSuppressionNoeud.Size = new System.Drawing.Size(195, 40);
            this.buttonSuppressionNoeud.TabIndex = 13;
            this.buttonSuppressionNoeud.Text = "Supprine noeud courant";
            this.buttonSuppressionNoeud.UseVisualStyleBackColor = true;
            this.buttonSuppressionNoeud.Click += new System.EventHandler(this.buttonSuppressionNoeud_Click);
            // 
            // btSeeTree
            // 
            this.btSeeTree.Location = new System.Drawing.Point(691, 413);
            this.btSeeTree.Name = "btSeeTree";
            this.btSeeTree.Size = new System.Drawing.Size(194, 30);
            this.btSeeTree.TabIndex = 14;
            this.btSeeTree.Text = "Affiche l\'arbre";
            this.btSeeTree.UseVisualStyleBackColor = true;
            this.btSeeTree.Click += new System.EventHandler(this.btSeeTree_Click);
            // 
            // trouveToolStripMenuItem
            // 
            this.trouveToolStripMenuItem.Name = "trouveToolStripMenuItem";
            this.trouveToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.trouveToolStripMenuItem.Text = "Trouve";
            this.trouveToolStripMenuItem.Click += new System.EventHandler(this.trouveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 473);
            this.Controls.Add(this.btSeeTree);
            this.Controls.Add(this.buttonSuppressionNoeud);
            this.Controls.Add(this.buttonInsertionNoeud);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.textBoxCle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_GetBackTreeview);
            this.Controls.Add(this.btSaveTreeview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.btChangeNodeName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btChangeNodeName;
    private System.Windows.Forms.TreeView treeView2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btSaveTreeview;
    private System.Windows.Forms.Button bt_GetBackTreeview;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxCle;
    private System.Windows.Forms.TextBox textBoxDesignation;
    private System.Windows.Forms.Button buttonInsertionNoeud;
    private System.Windows.Forms.Button buttonSuppressionNoeud;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem supprimerLeNoeudToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem insérerUnNoeudToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renimmerLeNoeudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriétésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficheLeParentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficheEnfantsToolStripMenuItem;
        private System.Windows.Forms.Button btSeeTree;
        private System.Windows.Forms.ToolStripMenuItem trouveToolStripMenuItem;
    }
}

