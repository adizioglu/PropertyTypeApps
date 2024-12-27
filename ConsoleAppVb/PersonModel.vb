Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ConsoleAppVb
    Public Class PersonModel
        Public Property FirstName As String
            Private Get
                Return m_FirstName
            End Get
            Set(value As String)
                m_FirstName = value
            End Set
        End Property
        Private m_FirstName As String

        Public ReadOnly Property LastName As String
            Get
                Return m_LastName
            End Get
        End Property
        Private m_LastName As String

        Private _password As String

        Public WriteOnly Property Password As String
            Set(value As String)
                _password = value
            End Set
        End Property

        Public ReadOnly Property FullName As String
            Get
                Return $"{FirstName} {LastName}"
            End Get
        End Property

        Private _age As Integer
        Public Property Age As Integer
            Get
                Return _age
            End Get
            Set(value As Integer)
                If value >= 0 AndAlso value < 126 Then
                    _age = value
                Else
                    Throw New ArgumentOutOfRangeException("value", "Age needs to be in a valid range.")
                End If
            End Set
        End Property

        Private _ssn As String
        Public Property SSN As String
            Get
                ' 123-45-6789 - 11 - 4 = 7
                Dim output As String = "***-**-" & _ssn.Substring(_ssn.Length - 4)
                Return output
            End Get
            Set(value As String)
                _ssn = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(lastName As String)
            m_LastName = lastName
        End Sub
    End Class
End Namespace
