<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Webmain = New System.Windows.Forms.WebBrowser
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tsUserName = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Ribbon1 = New System.Windows.Forms.Ribbon
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.SystemLoginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonnelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLogin = New System.Windows.Forms.RibbonButton
        Me.cmdLogout = New System.Windows.Forms.RibbonButton
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton
        Me.cmdExit = New System.Windows.Forms.RibbonButton
        Me.cmdPersonnel = New System.Windows.Forms.RibbonButton
        Me.cmdLogins = New System.Windows.Forms.RibbonButton
        Me.cmdCases = New System.Windows.Forms.RibbonButton
        Me.cmdCells = New System.Windows.Forms.RibbonButton
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton
        Me.cmdInmates = New System.Windows.Forms.RibbonButton
        Me.cmdHearing = New System.Windows.Forms.RibbonButton
        Me.cmdDischarge = New System.Windows.Forms.RibbonButton
        Me.cmdtransfer = New System.Windows.Forms.RibbonButton
        Me.cmdActivities = New System.Windows.Forms.RibbonButton
        Me.cmdTransferCell = New System.Windows.Forms.RibbonButton
        Me.cmdVisitor = New System.Windows.Forms.RibbonButton
        Me.cmdInmateLogs = New System.Windows.Forms.RibbonButton
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel
        Me.cmdContents = New System.Windows.Forms.RibbonButton
        Me.cmdAbout = New System.Windows.Forms.RibbonButton
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel
        Me.cmdSettings = New System.Windows.Forms.RibbonButton
        Me.cmdReturnProperty = New System.Windows.Forms.RibbonButton
        Me.RibbonOrbOptionButton1 = New System.Windows.Forms.RibbonOrbOptionButton
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1076, 514)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 462.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Webmain, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 183)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1068, 297)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Webmain
        '
        Me.Webmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Webmain.IsWebBrowserContextMenuEnabled = False
        Me.Webmain.Location = New System.Drawing.Point(467, 4)
        Me.Webmain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Webmain.Name = "Webmain"
        Me.Webmain.ScriptErrorsSuppressed = True
        Me.Webmain.Size = New System.Drawing.Size(597, 289)
        Me.Webmain.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(456, 289)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(448, 260)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Activities for Today"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 254)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(448, 260)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hearing Schedule for Today"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(442, 254)
        Me.DataGridView2.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsUserName, Me.tsDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(1, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1074, 29)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsUserName
        '
        Me.tsUserName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.tsUserName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUserName.Name = "tsUserName"
        Me.tsUserName.Size = New System.Drawing.Size(137, 24)
        Me.tsUserName.Text = "ToolStripStatusLabel1"
        '
        'tsDate
        '
        Me.tsDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDate.Name = "tsDate"
        Me.tsDate.Size = New System.Drawing.Size(133, 24)
        Me.tsDate.Text = "ToolStripStatusLabel2"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ToolStrip1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Ribbon1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1068, 172)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 149)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1068, 23)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Ribbon1.Location = New System.Drawing.Point(3, 3)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 447)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Nothing
        Me.Ribbon1.Size = New System.Drawing.Size(1062, 143)
        Me.Ribbon1.TabIndex = 3
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab1.Text = "Automated Information System"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.cmdLogin)
        Me.RibbonPanel1.Items.Add(Me.cmdLogout)
        Me.RibbonPanel1.Items.Add(Me.cmdExit)
        Me.RibbonPanel1.Text = "System"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.cmdPersonnel)
        Me.RibbonPanel2.Items.Add(Me.cmdLogins)
        Me.RibbonPanel2.Items.Add(Me.cmdCases)
        Me.RibbonPanel2.Items.Add(Me.cmdCells)
        Me.RibbonPanel2.Items.Add(Me.cmdInmates)
        Me.RibbonPanel2.Text = "Set-Up"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.cmdHearing)
        Me.RibbonPanel3.Items.Add(Me.cmdDischarge)
        Me.RibbonPanel3.Items.Add(Me.cmdtransfer)
        Me.RibbonPanel3.Items.Add(Me.cmdActivities)
        Me.RibbonPanel3.Items.Add(Me.cmdTransferCell)
        Me.RibbonPanel3.Items.Add(Me.cmdVisitor)
        Me.RibbonPanel3.Items.Add(Me.cmdInmateLogs)
        Me.RibbonPanel3.Items.Add(Me.cmdReturnProperty)
        Me.RibbonPanel3.Text = "Records"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel5)
        Me.RibbonTab2.Text = "Settings"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(79, 20)
        Me.ToolStripDropDownButton1.Text = "System"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LoginToolStripMenuItem.Text = "Log-In"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LogoutToolStripMenuItem.Text = "Log-Out"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(131, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemLoginsToolStripMenuItem, Me.PersonnelsToolStripMenuItem, Me.CellsToolStripMenuItem, Me.CasesToolStripMenuItem})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(79, 20)
        Me.ToolStripButton1.Text = "Set-Up"
        '
        'SystemLoginsToolStripMenuItem
        '
        Me.SystemLoginsToolStripMenuItem.Name = "SystemLoginsToolStripMenuItem"
        Me.SystemLoginsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SystemLoginsToolStripMenuItem.Text = "System Logins"
        '
        'PersonnelsToolStripMenuItem
        '
        Me.PersonnelsToolStripMenuItem.Name = "PersonnelsToolStripMenuItem"
        Me.PersonnelsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PersonnelsToolStripMenuItem.Text = "Personnels"
        '
        'CellsToolStripMenuItem
        '
        Me.CellsToolStripMenuItem.Name = "CellsToolStripMenuItem"
        Me.CellsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CellsToolStripMenuItem.Text = "Cells"
        '
        'CasesToolStripMenuItem
        '
        Me.CasesToolStripMenuItem.Name = "CasesToolStripMenuItem"
        Me.CasesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CasesToolStripMenuItem.Text = "Cases"
        '
        'cmdLogin
        '
        Me.cmdLogin.Image = Global.BJMPAIRS.My.Resources.Resources.lock_break
        Me.cmdLogin.SmallImage = CType(resources.GetObject("cmdLogin.SmallImage"), System.Drawing.Image)
        Me.cmdLogin.Text = "Log-In"
        '
        'cmdLogout
        '
        Me.cmdLogout.DropDownItems.Add(Me.RibbonButton1)
        Me.cmdLogout.Image = Global.BJMPAIRS.My.Resources.Resources.lock
        Me.cmdLogout.SmallImage = Global.BJMPAIRS.My.Resources.Resources.lock
        Me.cmdLogout.Text = "Log-Out"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'cmdExit
        '
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.SmallImage = CType(resources.GetObject("cmdExit.SmallImage"), System.Drawing.Image)
        Me.cmdExit.Text = "Exit"
        '
        'cmdPersonnel
        '
        Me.cmdPersonnel.Image = CType(resources.GetObject("cmdPersonnel.Image"), System.Drawing.Image)
        Me.cmdPersonnel.SmallImage = CType(resources.GetObject("cmdPersonnel.SmallImage"), System.Drawing.Image)
        Me.cmdPersonnel.Text = "Personnel"
        '
        'cmdLogins
        '
        Me.cmdLogins.Image = CType(resources.GetObject("cmdLogins.Image"), System.Drawing.Image)
        Me.cmdLogins.SmallImage = CType(resources.GetObject("cmdLogins.SmallImage"), System.Drawing.Image)
        Me.cmdLogins.Text = "Logins"
        '
        'cmdCases
        '
        Me.cmdCases.Image = CType(resources.GetObject("cmdCases.Image"), System.Drawing.Image)
        Me.cmdCases.SmallImage = CType(resources.GetObject("cmdCases.SmallImage"), System.Drawing.Image)
        Me.cmdCases.Text = "Cases"
        '
        'cmdCells
        '
        Me.cmdCells.DropDownItems.Add(Me.RibbonButton2)
        Me.cmdCells.Image = CType(resources.GetObject("cmdCells.Image"), System.Drawing.Image)
        Me.cmdCells.SmallImage = CType(resources.GetObject("cmdCells.SmallImage"), System.Drawing.Image)
        Me.cmdCells.Text = "Cells"
        '
        'RibbonButton2
        '
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = "RibbonButton2"
        '
        'cmdInmates
        '
        Me.cmdInmates.Image = CType(resources.GetObject("cmdInmates.Image"), System.Drawing.Image)
        Me.cmdInmates.SmallImage = CType(resources.GetObject("cmdInmates.SmallImage"), System.Drawing.Image)
        Me.cmdInmates.Text = "Inmates"
        '
        'cmdHearing
        '
        Me.cmdHearing.Image = CType(resources.GetObject("cmdHearing.Image"), System.Drawing.Image)
        Me.cmdHearing.SmallImage = CType(resources.GetObject("cmdHearing.SmallImage"), System.Drawing.Image)
        Me.cmdHearing.Text = "Hearing"
        '
        'cmdDischarge
        '
        Me.cmdDischarge.Image = CType(resources.GetObject("cmdDischarge.Image"), System.Drawing.Image)
        Me.cmdDischarge.SmallImage = CType(resources.GetObject("cmdDischarge.SmallImage"), System.Drawing.Image)
        Me.cmdDischarge.Text = "Discharge"
        '
        'cmdtransfer
        '
        Me.cmdtransfer.Image = CType(resources.GetObject("cmdtransfer.Image"), System.Drawing.Image)
        Me.cmdtransfer.SmallImage = CType(resources.GetObject("cmdtransfer.SmallImage"), System.Drawing.Image)
        Me.cmdtransfer.Text = "Transfer"
        '
        'cmdActivities
        '
        Me.cmdActivities.Image = CType(resources.GetObject("cmdActivities.Image"), System.Drawing.Image)
        Me.cmdActivities.SmallImage = CType(resources.GetObject("cmdActivities.SmallImage"), System.Drawing.Image)
        Me.cmdActivities.Text = "Activities"
        '
        'cmdTransferCell
        '
        Me.cmdTransferCell.Image = CType(resources.GetObject("cmdTransferCell.Image"), System.Drawing.Image)
        Me.cmdTransferCell.SmallImage = CType(resources.GetObject("cmdTransferCell.SmallImage"), System.Drawing.Image)
        Me.cmdTransferCell.Text = "Transfer Cell"
        '
        'cmdVisitor
        '
        Me.cmdVisitor.Image = Global.BJMPAIRS.My.Resources.Resources.calendar
        Me.cmdVisitor.SmallImage = CType(resources.GetObject("cmdVisitor.SmallImage"), System.Drawing.Image)
        Me.cmdVisitor.Text = "Visitors"
        '
        'cmdInmateLogs
        '
        Me.cmdInmateLogs.Image = CType(resources.GetObject("cmdInmateLogs.Image"), System.Drawing.Image)
        Me.cmdInmateLogs.SmallImage = CType(resources.GetObject("cmdInmateLogs.SmallImage"), System.Drawing.Image)
        Me.cmdInmateLogs.Text = "Inmate Logs"
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab3.Text = "Help"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.cmdContents)
        Me.RibbonPanel4.Items.Add(Me.cmdAbout)
        Me.RibbonPanel4.Text = ""
        '
        'cmdContents
        '
        Me.cmdContents.Image = CType(resources.GetObject("cmdContents.Image"), System.Drawing.Image)
        Me.cmdContents.SmallImage = CType(resources.GetObject("cmdContents.SmallImage"), System.Drawing.Image)
        Me.cmdContents.Text = "Contents"
        '
        'cmdAbout
        '
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.SmallImage = CType(resources.GetObject("cmdAbout.SmallImage"), System.Drawing.Image)
        Me.cmdAbout.Text = "About"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.Items.Add(Me.cmdSettings)
        Me.RibbonPanel5.Text = ""
        '
        'cmdSettings
        '
        Me.cmdSettings.Image = CType(resources.GetObject("cmdSettings.Image"), System.Drawing.Image)
        Me.cmdSettings.SmallImage = CType(resources.GetObject("cmdSettings.SmallImage"), System.Drawing.Image)
        Me.cmdSettings.Text = "System Settings"
        '
        'cmdReturnProperty
        '
        Me.cmdReturnProperty.Image = CType(resources.GetObject("cmdReturnProperty.Image"), System.Drawing.Image)
        Me.cmdReturnProperty.SmallImage = CType(resources.GetObject("cmdReturnProperty.SmallImage"), System.Drawing.Image)
        Me.cmdReturnProperty.Text = "Return Property"
        '
        'RibbonOrbOptionButton1
        '
        Me.RibbonOrbOptionButton1.Image = CType(resources.GetObject("RibbonOrbOptionButton1.Image"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.SmallImage = CType(resources.GetObject("RibbonOrbOptionButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.Text = "RibbonOrbOptionButton1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1076, 514)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Webmain As System.Windows.Forms.WebBrowser
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SystemLoginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonnelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents RibbonTab1 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents cmdLogin As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdLogout As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton1 As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdExit As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel2 As System.Windows.Forms.RibbonPanel
    Friend WithEvents RibbonPanel3 As System.Windows.Forms.RibbonPanel
    Friend WithEvents RibbonTab2 As System.Windows.Forms.RibbonTab
    Friend WithEvents cmdPersonnel As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdLogins As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdCases As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdCells As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton2 As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdInmates As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdHearing As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdDischarge As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdtransfer As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdActivities As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdTransferCell As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdVisitor As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdInmateLogs As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel5 As System.Windows.Forms.RibbonPanel
    Friend WithEvents cmdSettings As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonTab3 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel4 As System.Windows.Forms.RibbonPanel
    Friend WithEvents cmdContents As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdAbout As System.Windows.Forms.RibbonButton
    Friend WithEvents cmdReturnProperty As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonOrbOptionButton1 As System.Windows.Forms.RibbonOrbOptionButton

End Class
