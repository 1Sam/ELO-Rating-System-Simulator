<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FormSkin1 = New ELO_Rating_System_Simulator.FormSkin()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MdButton3 = New ELO_Rating_System_Simulator.MDButton()
        Me.MdButton2 = New ELO_Rating_System_Simulator.MDButton()
        Me.MdButton1 = New ELO_Rating_System_Simulator.MDButton()
        Me.MdStickyButton1 = New ELO_Rating_System_Simulator.MDStickyButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BlueOrigin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BlueResult = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RedOrigin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RedResult = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(19, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(526, 30)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "K-factor 는 승패에 따라 나눠 갖게 되는 절대값입니다."
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.CheckBox1)
        Me.FormSkin1.Controls.Add(Me.MdButton3)
        Me.FormSkin1.Controls.Add(Me.MdButton2)
        Me.FormSkin1.Controls.Add(Me.MdButton1)
        Me.FormSkin1.Controls.Add(Me.MdStickyButton1)
        Me.FormSkin1.Controls.Add(Me.TextBox1)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.BlueOrigin)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.TextBox5)
        Me.FormSkin1.Controls.Add(Me.TextBox4)
        Me.FormSkin1.Controls.Add(Me.TextBox2)
        Me.FormSkin1.Controls.Add(Me.BlueResult)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.RedOrigin)
        Me.FormSkin1.Controls.Add(Me.Label9)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.TextBox3)
        Me.FormSkin1.Controls.Add(Me.RedResult)
        Me.FormSkin1.Controls.Add(Me.Label8)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.Button2)
        Me.FormSkin1.Controls.Add(Me.Button1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.LightTheme = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.MDColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(570, 431)
        Me.FormSkin1.TabIndex = 3
        Me.FormSkin1.Text = "MMR 실험기"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(162, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(269, 25)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "승리 결과값을 그래프에 바로 추가"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'MdButton3
        '
        Me.MdButton3.BackColor = System.Drawing.Color.Transparent
        Me.MdButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MdButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MdButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MdButton3.Location = New System.Drawing.Point(297, 357)
        Me.MdButton3.Name = "MdButton3"
        Me.MdButton3.Rounded = False
        Me.MdButton3.Size = New System.Drawing.Size(100, 32)
        Me.MdButton3.TabIndex = 7
        Me.MdButton3.Text = "결과값 치환"
        Me.MdButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToolTip1.SetToolTip(Me.MdButton3, "'경기전' 점수에 '경기후'의 값을 치환함 그래프에 결과값 추가")
        '
        'MdButton2
        '
        Me.MdButton2.BackColor = System.Drawing.Color.Transparent
        Me.MdButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MdButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MdButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MdButton2.Location = New System.Drawing.Point(162, 357)
        Me.MdButton2.Name = "MdButton2"
        Me.MdButton2.Rounded = False
        Me.MdButton2.Size = New System.Drawing.Size(100, 32)
        Me.MdButton2.TabIndex = 6
        Me.MdButton2.Text = "결과값 치환"
        Me.MdButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToolTip1.SetToolTip(Me.MdButton2, "'경기전' 점수에 '경기후'의 값을 치환함 그래프에 결과값 추가")
        '
        'MdButton1
        '
        Me.MdButton1.BackColor = System.Drawing.Color.Transparent
        Me.MdButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MdButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MdButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MdButton1.Location = New System.Drawing.Point(417, 357)
        Me.MdButton1.Name = "MdButton1"
        Me.MdButton1.Rounded = False
        Me.MdButton1.Size = New System.Drawing.Size(128, 32)
        Me.MdButton1.TabIndex = 4
        Me.MdButton1.Text = "그래프 창 열기"
        Me.MdButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MdStickyButton1
        '
        Me.MdStickyButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MdStickyButton1.BackColor = System.Drawing.Color.Transparent
        Me.MdStickyButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MdStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MdStickyButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MdStickyButton1.Location = New System.Drawing.Point(535, 12)
        Me.MdStickyButton1.Name = "MdStickyButton1"
        Me.MdStickyButton1.Rounded = False
        Me.MdStickyButton1.Size = New System.Drawing.Size(23, 23)
        Me.MdStickyButton1.TabIndex = 3
        Me.MdStickyButton1.Text = "X"
        Me.MdStickyButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.ELO_Rating_System_Simulator.My.MySettings.Default, "Kfactor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(162, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 39)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.ELO_Rating_System_Simulator.My.MySettings.Default.Kfactor
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBox1, "승리 패배시의 보상값을 결정하는 상수")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(61, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 30)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "K-factor"
        '
        'BlueOrigin
        '
        Me.BlueOrigin.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BlueOrigin.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BlueOrigin.Location = New System.Drawing.Point(162, 219)
        Me.BlueOrigin.Name = "BlueOrigin"
        Me.BlueOrigin.Size = New System.Drawing.Size(100, 39)
        Me.BlueOrigin.TabIndex = 2
        Me.BlueOrigin.Text = "1500"
        Me.BlueOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.Location = New System.Drawing.Point(79, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 30)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "경기전"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox5.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(403, 144)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 39)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBox5, "점수 차이에 따른 레드팀 승률")
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox4.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(56, 144)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 39)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBox4, "점수 차이에 따른 블루팀 승률")
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox2.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(162, 309)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 39)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BlueResult
        '
        Me.BlueResult.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BlueResult.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BlueResult.Location = New System.Drawing.Point(162, 264)
        Me.BlueResult.Name = "BlueResult"
        Me.BlueResult.ReadOnly = True
        Me.BlueResult.Size = New System.Drawing.Size(100, 39)
        Me.BlueResult.TabIndex = 4
        Me.BlueResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Info
        Me.Label7.Location = New System.Drawing.Point(100, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 30)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "증감"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(79, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "경기후"
        '
        'RedOrigin
        '
        Me.RedOrigin.BackColor = System.Drawing.Color.Tomato
        Me.RedOrigin.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RedOrigin.ForeColor = System.Drawing.SystemColors.Info
        Me.RedOrigin.Location = New System.Drawing.Point(297, 219)
        Me.RedOrigin.Name = "RedOrigin"
        Me.RedOrigin.Size = New System.Drawing.Size(100, 39)
        Me.RedOrigin.TabIndex = 3
        Me.RedOrigin.Text = "1500"
        Me.RedOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSalmon
        Me.Label9.Location = New System.Drawing.Point(412, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 30)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "승률"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSalmon
        Me.Label2.Location = New System.Drawing.Point(308, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "레드팀"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Tomato
        Me.TextBox3.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(297, 309)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 39)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RedResult
        '
        Me.RedResult.BackColor = System.Drawing.Color.Tomato
        Me.RedResult.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RedResult.ForeColor = System.Drawing.SystemColors.Info
        Me.RedResult.Location = New System.Drawing.Point(297, 264)
        Me.RedResult.Name = "RedResult"
        Me.RedResult.ReadOnly = True
        Me.RedResult.Size = New System.Drawing.Size(100, 39)
        Me.RedResult.TabIndex = 5
        Me.RedResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(79, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 30)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "승률"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(172, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "블루팀"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.Location = New System.Drawing.Point(297, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "레드승리"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(162, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "블루승리"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 431)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form11"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RedResult As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RedOrigin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BlueResult As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BlueOrigin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents MdStickyButton1 As MDStickyButton
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MdButton1 As MDButton
    Friend WithEvents MdButton3 As MDButton
    Friend WithEvents MdButton2 As MDButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
