namespace MetodosOrdenamiento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblGraficoOrdenado = new System.Windows.Forms.Label();
            this.lblGraficoDesordenado = new System.Windows.Forms.Label();
            this.dgvMetodos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iteraciones1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elementos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.gbMetodo = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.optMerge = new System.Windows.Forms.RadioButton();
            this.optQuick = new System.Windows.Forms.RadioButton();
            this.optBubble = new System.Windows.Forms.RadioButton();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.grDesordenado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grOrdenado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGraficos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarGraficos = new System.Windows.Forms.Button();
            this.btnLimpiarGrilla = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodos)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.gbMetodo.SuspendLayout();
            this.gbElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDesordenado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grOrdenado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGraficoOrdenado
            // 
            this.lblGraficoOrdenado.AutoSize = true;
            this.lblGraficoOrdenado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoOrdenado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGraficoOrdenado.Location = new System.Drawing.Point(1037, 317);
            this.lblGraficoOrdenado.Name = "lblGraficoOrdenado";
            this.lblGraficoOrdenado.Size = new System.Drawing.Size(170, 20);
            this.lblGraficoOrdenado.TabIndex = 21;
            this.lblGraficoOrdenado.Text = "Elementos Ordenados";
            // 
            // lblGraficoDesordenado
            // 
            this.lblGraficoDesordenado.AutoSize = true;
            this.lblGraficoDesordenado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoDesordenado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGraficoDesordenado.Location = new System.Drawing.Point(1037, 27);
            this.lblGraficoDesordenado.Name = "lblGraficoDesordenado";
            this.lblGraficoDesordenado.Size = new System.Drawing.Size(196, 20);
            this.lblGraficoDesordenado.TabIndex = 20;
            this.lblGraficoDesordenado.Text = "Elementos Desordenados";
            // 
            // dgvMetodos
            // 
            this.dgvMetodos.AllowUserToAddRows = false;
            this.dgvMetodos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvMetodos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetodos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMetodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Iteraciones1,
            this.Tiempo,
            this.Elementos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMetodos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMetodos.Location = new System.Drawing.Point(395, 22);
            this.dgvMetodos.Name = "dgvMetodos";
            this.dgvMetodos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMetodos.RowHeadersWidth = 51;
            this.dgvMetodos.RowTemplate.Height = 24;
            this.dgvMetodos.Size = new System.Drawing.Size(611, 568);
            this.dgvMetodos.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Iteraciones1
            // 
            this.Iteraciones1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Iteraciones1.HeaderText = "Iteraciones ";
            this.Iteraciones1.MinimumWidth = 6;
            this.Iteraciones1.Name = "Iteraciones1";
            this.Iteraciones1.ReadOnly = true;
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.MinimumWidth = 6;
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // Elementos
            // 
            this.Elementos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Elementos.HeaderText = "Cantidad de Elementos";
            this.Elementos.MinimumWidth = 6;
            this.Elementos.Name = "Elementos";
            this.Elementos.ReadOnly = true;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.lblTiempo);
            this.gbResultados.Controls.Add(this.lblIteraciones);
            this.gbResultados.Controls.Add(this.txtIteraciones);
            this.gbResultados.Controls.Add(this.txtTiempo);
            this.gbResultados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultados.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbResultados.Location = new System.Drawing.Point(19, 329);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(346, 133);
            this.gbResultados.TabIndex = 18;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTiempo.Location = new System.Drawing.Point(19, 44);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(56, 20);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIteraciones.Location = new System.Drawing.Point(183, 43);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(81, 20);
            this.lblIteraciones.TabIndex = 9;
            this.lblIteraciones.Text = "Iteraciones";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteraciones.Location = new System.Drawing.Point(179, 66);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.ReadOnly = true;
            this.txtIteraciones.Size = new System.Drawing.Size(144, 22);
            this.txtIteraciones.TabIndex = 1;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(16, 66);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(126, 22);
            this.txtTiempo.TabIndex = 0;
            // 
            // gbMetodo
            // 
            this.gbMetodo.Controls.Add(this.btnOrdenar);
            this.gbMetodo.Controls.Add(this.optMerge);
            this.gbMetodo.Controls.Add(this.optQuick);
            this.gbMetodo.Controls.Add(this.optBubble);
            this.gbMetodo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMetodo.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbMetodo.Location = new System.Drawing.Point(19, 165);
            this.gbMetodo.Name = "gbMetodo";
            this.gbMetodo.Size = new System.Drawing.Size(346, 152);
            this.gbMetodo.TabIndex = 17;
            this.gbMetodo.TabStop = false;
            this.gbMetodo.Text = "Defina Metodo de Ordenamineto";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOrdenar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrdenar.Location = new System.Drawing.Point(224, 63);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(84, 33);
            this.btnOrdenar.TabIndex = 16;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // optMerge
            // 
            this.optMerge.AutoSize = true;
            this.optMerge.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optMerge.Location = new System.Drawing.Point(27, 93);
            this.optMerge.Name = "optMerge";
            this.optMerge.Size = new System.Drawing.Size(102, 24);
            this.optMerge.TabIndex = 10;
            this.optMerge.TabStop = true;
            this.optMerge.Text = "Merge Sort";
            this.optMerge.UseVisualStyleBackColor = true;
            // 
            // optQuick
            // 
            this.optQuick.AutoSize = true;
            this.optQuick.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optQuick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optQuick.Location = new System.Drawing.Point(27, 67);
            this.optQuick.Name = "optQuick";
            this.optQuick.Size = new System.Drawing.Size(98, 24);
            this.optQuick.TabIndex = 9;
            this.optQuick.TabStop = true;
            this.optQuick.Text = "Quick Sort";
            this.optQuick.UseVisualStyleBackColor = true;
            // 
            // optBubble
            // 
            this.optBubble.AutoSize = true;
            this.optBubble.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBubble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optBubble.Location = new System.Drawing.Point(27, 41);
            this.optBubble.Name = "optBubble";
            this.optBubble.Size = new System.Drawing.Size(106, 24);
            this.optBubble.TabIndex = 8;
            this.optBubble.TabStop = true;
            this.optBubble.Text = "Bubble Sort";
            this.optBubble.UseVisualStyleBackColor = true;
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.numericUpDown1);
            this.gbElementos.Controls.Add(this.btnGenerar);
            this.gbElementos.Controls.Add(this.lblLongitud);
            this.gbElementos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbElementos.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbElementos.Location = new System.Drawing.Point(20, 27);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(346, 126);
            this.gbElementos.TabIndex = 16;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Defina Cantidad de elementos";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerar.Location = new System.Drawing.Point(223, 45);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(84, 33);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLongitud.Location = new System.Drawing.Point(18, 42);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(130, 20);
            this.lblLongitud.TabIndex = 3;
            this.lblLongitud.Text = "Longitud de Vector";
            // 
            // grDesordenado
            // 
            chartArea1.Name = "ChartArea1";
            this.grDesordenado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grDesordenado.Legends.Add(legend1);
            this.grDesordenado.Location = new System.Drawing.Point(1027, 50);
            this.grDesordenado.Name = "grDesordenado";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grDesordenado.Series.Add(series1);
            this.grDesordenado.Size = new System.Drawing.Size(568, 247);
            this.grDesordenado.TabIndex = 22;
            this.grDesordenado.Text = "Elementos";
            // 
            // grOrdenado
            // 
            chartArea2.Name = "ChartArea1";
            this.grOrdenado.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grOrdenado.Legends.Add(legend2);
            this.grOrdenado.Location = new System.Drawing.Point(1027, 342);
            this.grOrdenado.Name = "grOrdenado";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.SteelBlue;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grOrdenado.Series.Add(series2);
            this.grOrdenado.Size = new System.Drawing.Size(568, 248);
            this.grOrdenado.TabIndex = 23;
            this.grOrdenado.Text = "chart2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGraficos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLimpiarGraficos);
            this.groupBox1.Controls.Add(this.btnLimpiarGrilla);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(20, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 122);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limpiar";
            // 
            // lblGraficos
            // 
            this.lblGraficos.AutoSize = true;
            this.lblGraficos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGraficos.Location = new System.Drawing.Point(22, 71);
            this.lblGraficos.Name = "lblGraficos";
            this.lblGraficos.Size = new System.Drawing.Size(63, 20);
            this.lblGraficos.TabIndex = 27;
            this.lblGraficos.Text = "Graficos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Grilla";
            // 
            // btnLimpiarGraficos
            // 
            this.btnLimpiarGraficos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiarGraficos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGraficos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarGraficos.Location = new System.Drawing.Point(160, 68);
            this.btnLimpiarGraficos.Name = "btnLimpiarGraficos";
            this.btnLimpiarGraficos.Size = new System.Drawing.Size(88, 26);
            this.btnLimpiarGraficos.TabIndex = 25;
            this.btnLimpiarGraficos.Text = "Limpiar";
            this.btnLimpiarGraficos.UseVisualStyleBackColor = false;
            this.btnLimpiarGraficos.Click += new System.EventHandler(this.btnLimpiarGraficos_Click);
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiarGrilla.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGrilla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(160, 34);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(88, 26);
            this.btnLimpiarGrilla.TabIndex = 24;
            this.btnLimpiarGrilla.Text = "Limpiar";
            this.btnLimpiarGrilla.UseVisualStyleBackColor = false;
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(15, 65);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 25);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1623, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grOrdenado);
            this.Controls.Add(this.grDesordenado);
            this.Controls.Add(this.lblGraficoOrdenado);
            this.Controls.Add(this.lblGraficoDesordenado);
            this.Controls.Add(this.dgvMetodos);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbMetodo);
            this.Controls.Add(this.gbElementos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodos)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.gbMetodo.ResumeLayout(false);
            this.gbMetodo.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.gbElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDesordenado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grOrdenado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGraficoOrdenado;
        private System.Windows.Forms.Label lblGraficoDesordenado;
        private System.Windows.Forms.DataGridView dgvMetodos;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.GroupBox gbMetodo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton optMerge;
        private System.Windows.Forms.RadioButton optQuick;
        private System.Windows.Forms.RadioButton optBubble;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteraciones1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elementos;
        private System.Windows.Forms.DataVisualization.Charting.Chart grDesordenado;
        private System.Windows.Forms.DataVisualization.Charting.Chart grOrdenado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGraficos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarGraficos;
        private System.Windows.Forms.Button btnLimpiarGrilla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

