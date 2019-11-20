Module Module1

    Dim valEntree As String = ""
    Dim val1 As Double = 0
    Dim val2 As Double = 0
    Dim result As Double = 0
    Dim nbMenu As Integer

    'Méthode qui affiche les menus disponible
    Sub afficheMenu()
        Console.WriteLine("- Bienvenue dans la minicalculatrice en VB.NET -")
        Console.WriteLine("")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Soustraction")
        Console.WriteLine("3. Multiplication")
        Console.WriteLine("4. Division")
        Console.WriteLine("5. Quitter le programme")
        Console.WriteLine()
    End Sub

    'Méthode de fin de programme (Menu 5)
    Sub endProgram()
        Console.WriteLine()
        Console.WriteLine("Merci d'avoir utiliser notre programme et à bientôt...")
        Console.WriteLine("Appuyer sur entrée pour quitter le programme")
        Console.ReadLine()
    End Sub

    'Méthode d'addition de deux nombres (Menu 1)
    Sub addition()
        Console.WriteLine()
        Console.WriteLine("- Addition -")
        'Demande du premier nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val1
        Do
            Console.WriteLine("Entrez le premier nombre")
            valEntree = Console.ReadLine()
        Loop Until IsNumeric(valEntree)

        val1 = valEntree

        'Demande du second nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val2
        Do
            Console.WriteLine("Entrez le second nombre")
            valEntree = Console.ReadLine()
        Loop While Not IsNumeric(valEntree)

        val2 = valEntree

        ' Opération d'addition
        result = val1 + val2
        Console.WriteLine(val1 & " + " & val2 & " = " & result)
        Console.WriteLine()
    End Sub

    'Méthode de soustraction de deux nombres (Menu 2)
    Sub soustraction()
        Console.WriteLine()
        Console.WriteLine("- Soustraction -")
        'Demande du premier nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val1
        Do
            Console.WriteLine("Entrez le premier nombre")
            valEntree = Console.ReadLine()
        Loop Until IsNumeric(valEntree)

        val1 = valEntree

        'Demande du second nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val2
        Do
            Console.WriteLine("Entrez le second nombre")
            valEntree = Console.ReadLine()
        Loop While Not IsNumeric(valEntree)

        val2 = valEntree

        ' Opération de soustraction
        result = val1 - val2
        Console.WriteLine(val1 & " - " & val2 & " = " & result)
        Console.WriteLine()
    End Sub

    'Méthode de multiplication de deux nombres (Menu 3)
    Sub multiplication()
        Console.WriteLine()
        Console.WriteLine("- Multiplication -")
        'Demande du premier nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val1
        Do
            Console.WriteLine("Entrez le premier nombre")
            valEntree = Console.ReadLine()
        Loop Until IsNumeric(valEntree)

        val1 = valEntree

        'Demande du second nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val2
        Do
            Console.WriteLine("Entrez le second nombre")
            valEntree = Console.ReadLine()
        Loop While Not IsNumeric(valEntree)

        val2 = valEntree

        ' Opération de multiplication
        result = val1 * val2
        Console.WriteLine(val1 & " X " & val2 & " = " & result)
        Console.WriteLine()
    End Sub

    'Méthode de division de deux nombres (Menu 4)
    Sub division()
        Console.WriteLine()
        Console.WriteLine("- Division -")
        'Demande du premier nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val1
        Do
            Console.WriteLine("Entrez le premier nombre")
            valEntree = Console.ReadLine()
        Loop Until IsNumeric(valEntree)

        val1 = valEntree

        'Demande du second nombre et vérification que c'est bien un nombre avant de le mettre dans la variable val2
        Do
            Console.WriteLine("Entrez le second nombre")
            valEntree = Console.ReadLine()
        Loop While Not IsNumeric(valEntree)

        val2 = valEntree

        ' Opération de division
        result = val1 / val2
        Console.WriteLine(val1 & " / " & val2 & " = " & result)
        Console.WriteLine()
    End Sub

    'Méthode Main du programme de la minicalculatrice
    Sub Main()
        Dim bool1 As Boolean = False

        Do
            afficheMenu()
            Console.WriteLine("Entrer votre choix : ")
            Try
                nbMenu = Int16.Parse(Console.ReadLine())
                bool1 = True
            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine("Veuillez entrer un entier valide")
            End Try
            Select Case nbMenu
                Case 1
                    addition()
                Case 2
                    soustraction()
                Case 3
                    multiplication()
                Case 4
                    division()
                Case 5
                    bool1 = True
                    endProgram()
                Case Else
                    Console.WriteLine()
                    Console.WriteLine("Mauvais choix de menu, veuillez recommencer : ")
                    Console.WriteLine()
            End Select
        Loop While nbMenu <> 5 Or bool1 = False

    End Sub

End Module
