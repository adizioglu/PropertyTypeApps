Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ConsoleAppVb
    Class Program
        Shared Sub Main(args As String())
            Dim person As New PersonModel("Dizioglu")

            person.FirstName = "Ahmet"
            'person.LastName = "Dizioglu"
            person.Age = 40
            person.SSN = "123-45-6789"

            Console.WriteLine(person.FullName)
            Console.WriteLine(person.SSN)

            Console.ReadLine()
        End Sub
    End Class
End Namespace
