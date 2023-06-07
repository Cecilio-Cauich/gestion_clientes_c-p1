namespace ejercicio_POO
{
    partial class GestionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listClients = new ListBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtTarjetaCredito = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            btnEditar = new Button();
            label6 = new Label();
            lblID = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // listClients
            // 
            listClients.FormattingEnabled = true;
            listClients.ItemHeight = 20;
            listClients.Location = new Point(31, 39);
            listClients.Name = "listClients";
            listClients.Size = new Size(330, 304);
            listClients.TabIndex = 0;
            listClients.SelectedIndexChanged += listClients_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(677, 295);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(267, 357);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(519, 137);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(252, 27);
            txtApellido.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 141);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 190);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(519, 190);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(252, 27);
            txtTelefono.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 246);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 9;
            label4.Text = "Tarjeta Crédito";
            label4.Click += label4_Click;
            // 
            // txtTarjetaCredito
            // 
            txtTarjetaCredito.Location = new Point(547, 242);
            txtTarjetaCredito.Name = "txtTarjetaCredito";
            txtTarjetaCredito.Size = new Size(224, 27);
            txtTarjetaCredito.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(519, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 11;
            txtNombre.TextChanged += txtNombre_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(387, 39);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 12;
            label5.Text = "Formulario:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(167, 357);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 17);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 14;
            label6.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(547, 17);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 20);
            lblID.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(67, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(txtTarjetaCredito);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(listClients);
            Name = "GestionClientes";
            Text = "GestionClientes";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox listClients;
        private Label label1;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox txtApellido;
        private Label label2;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtTarjetaCredito;
        private TextBox txtNombre;
        private Label label5;
        private Button btnEditar;
        private Label label6;
        private Label lblID;
        private Button btnAgregar;
    }
}