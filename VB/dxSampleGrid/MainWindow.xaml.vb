Imports System.Windows
Imports System.ComponentModel.DataAnnotations

Namespace dxSampleGrid
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            DataContext = New MyViewModel()
        End Sub
    End Class



    Public Class Person

        Public Sub New(ByVal i As Integer)
            FirstName = "FirstName" & i
            LastName = "LastName" & i
            Age = i * 10
            HasChildren = i Mod 2 = 0
        End Sub

        <Display(GroupName := "Tab1")> _
        Public Property FirstName() As String
        <Display(GroupName := "Tab1")> _
        Public Property LastName() As String


        <Display(GroupName := "Tab2")> _
        Public Property Age() As Integer
        <Display(GroupName := "Tab2")> _
        Public Property HasChildren() As Boolean
    End Class

    Public Class MyViewModel
        Public Sub New()
            SelectedPerson = New Person(55)
        End Sub
        Public Property SelectedPerson() As Person
    End Class


End Namespace
