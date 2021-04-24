
namespace TreevIEW
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
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.treeView2 = new System.Windows.Forms.TreeView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxCle = new System.Windows.Forms.TextBox();
      this.textBoxDesignation = new System.Windows.Forms.TextBox();
      this.buttonInsertionNoeud = new System.Windows.Forms.Button();
      this.buttonSuppressionNoeud = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // treeView1
      // 
      this.treeView1.Location = new System.Drawing.Point(22, 42);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(296, 386);
      this.treeView1.TabIndex = 0;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(681, 42);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(194, 22);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "Nouveau nom";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(681, 70);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(194, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Renomme avec le contenu du dessus";
      this.button1.UseVisualStyleBackColor = true;
    
      // 
      // treeView2
      // 
      this.treeView2.Location = new System.Drawing.Point(350, 42);
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
      this.label2.Location = new System.Drawing.Point(358, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 17);
      this.label2.TabIndex = 5;
      this.label2.Text = "Treeview2";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(57, 437);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(194, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Enregistre Treeview1";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(350, 437);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(242, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "Rappel fichier dans treeView2";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
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
      this.textBoxCle.Location = new System.Drawing.Point(690, 274);
      this.textBoxCle.Name = "textBoxCle";
      this.textBoxCle.Size = new System.Drawing.Size(194, 22);
      this.textBoxCle.TabIndex = 10;
      this.textBoxCle.Text = "Key";
      // 
      // textBoxDesignation
      // 
      this.textBoxDesignation.Location = new System.Drawing.Point(690, 325);
      this.textBoxDesignation.Name = "textBoxDesignation";
      this.textBoxDesignation.Size = new System.Drawing.Size(194, 22);
      this.textBoxDesignation.TabIndex = 11;
      this.textBoxDesignation.Text = "D";
      // 
      // buttonInsertionNoeud
      // 
      this.buttonInsertionNoeud.Location = new System.Drawing.Point(690, 353);
      this.buttonInsertionNoeud.Name = "buttonInsertionNoeud";
      this.buttonInsertionNoeud.Size = new System.Drawing.Size(194, 43);
      this.buttonInsertionNoeud.TabIndex = 12;
      this.buttonInsertionNoeud.Text = "Insère noeud avec données ci-dessus";
      this.buttonInsertionNoeud.UseVisualStyleBackColor = true;
      this.buttonInsertionNoeud.Click += new System.EventHandler(this.button4_Click);
      // 
      // buttonSuppressionNoeud
      // 
      this.buttonSuppressionNoeud.Location = new System.Drawing.Point(681, 111);
      this.buttonSuppressionNoeud.Name = "buttonSuppressionNoeud";
      this.buttonSuppressionNoeud.Size = new System.Drawing.Size(194, 23);
      this.buttonSuppressionNoeud.TabIndex = 13;
      this.buttonSuppressionNoeud.Text = "Supprine noeud courant";
      this.buttonSuppressionNoeud.UseVisualStyleBackColor = true;
      this.buttonSuppressionNoeud.Click += new System.EventHandler(this.buttonSuppressionNoeud_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(992, 472);
      this.Controls.Add(this.buttonSuppressionNoeud);
      this.Controls.Add(this.buttonInsertionNoeud);
      this.Controls.Add(this.textBoxDesignation);
      this.Controls.Add(this.textBoxCle);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.treeView2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.treeView1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TreeView treeView2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxCle;
    private System.Windows.Forms.TextBox textBoxDesignation;
    private System.Windows.Forms.Button buttonInsertionNoeud;
    private System.Windows.Forms.Button buttonSuppressionNoeud;
  }
}

