Module Module1

    'Initialisation des variables
    Dim choice, val1, val2, result, tabInt(4), tabInt2(40), tabInt2D(3, 4), tabInt3D(2, 3, 4) As Integer
    Const testString As String = "Phrase de test"
    Const hWorld As String = "Hello World"
    Dim joursSemaine As jours

    Enum jours
        Lundi
        Mardi
        Mercredi
        Jeudi
        Vendredi
        Samedi
        Dimanche
    End Enum
    Structure FicheLivre
        Dim ID As Integer
        Dim Titre As String
        Dim Auteur As String
        Dim Genre As String
    End Structure

    Sub affichageMenus()
        Console.WriteLine("")
        Console.WriteLine("Programme d'entrainement VB.NET : ")
        Console.WriteLine("")
        Console.WriteLine("Veuillez choisir dans le menu principal : ")
        Console.WriteLine("- Option 1 = Hello World")
        Console.WriteLine("- Option 2 = Addition")
        Console.WriteLine("- Option 3 = Multiplication")
        Console.WriteLine("- Option 4 = Remplacement Mot (test --> testReplace)")
        Console.WriteLine("- Option 5 = Manipulation String (MAJUSCULE/miniscule)")
        Console.WriteLine("- Option 6 = Manipulation Date (ToShortDataString & ToShortTimeString")
        Console.WriteLine("- Option 7 = Afficher heure locale complète")
        Console.WriteLine("- Option 8 = Manipulation de tableaux")
        Console.WriteLine("- Option 9 = Remplir et trier tableaux")
        Console.WriteLine("- Option 10 = Remplir tableau et additionner les valeurs")
        Console.WriteLine("- Option 11 = Création et utilisation de structures")
        Console.WriteLine("- Option 12 = Utilisation du IIF")
        Console.WriteLine("- Option 13 = MsgBox & InputBox")
        Console.WriteLine("- Option 14 = Fin du programme")
        Console.WriteLine("")
        Console.WriteLine("Entrer votre choix : ")
    End Sub

    Sub helloWorld()
        'Affiche variable hWorld
        Console.WriteLine(hWorld)
        Console.WriteLine()
    End Sub

    ''' <summary>
    ''' Additionne les valeurs passées en arguments
    ''' </summary>
    ''' <param name="add1">Première valeur à ajouter</param>
    ''' <param name="add2">Seconde valeur à ajouter</param>
    ''' <returns>Résultat de l'addition des arguments</returns>
    Function addition(add1 As Integer, add2 As Integer) As Integer
        Dim resultAdd As Integer
        'Opération d'addition
        resultAdd = add1 + add2
        Return resultAdd
    End Function

    ''' <summary>
    ''' Multiplie les valeurs passées en arguments
    ''' </summary>
    ''' <param name="multi1">Première valeur à multiplier</param>
    ''' <param name="multi2">Seconde valeur à multiplier</param>
    ''' <returns>Résultat de la multiplication des arguments</returns>
    Function multiplication(multi1 As Integer, multi2 As Integer) As Integer
        Dim resultMulti As Integer
        resultMulti = multi1 * multi2
        Return resultMulti
    End Function
    Function DemandeValeur(ByVal Numero As Integer) As Integer
        Dim ValeurEntree As Object

        'Demande la valeur
        Do
            Console.WriteLine("Entrez valeur " & Numero + 1)
            ValeurEntree = Console.ReadLine()
            'Tourne tant que ce n'est pas un nombre
        Loop Until IsNumeric(ValeurEntree)

        'Convertit la valeur en integer
        ValeurEntree = CInt(ValeurEntree)
        Return ValeurEntree
    End Function

    Sub fillTabAndAddValues()
        Dim TableauDeValeurs(9) As Integer
        Dim Resultat As Integer = 0

        'Demande les valeurs en passant par la fonction
        For i As Integer = 0 To TableauDeValeurs.Length - 1
            TableauDeValeurs(i) = DemandeValeur(i)
        Next

        'Additionne les valeurs
        For i As Integer = 0 To TableauDeValeurs.Length - 1
            Resultat = Resultat + TableauDeValeurs(i)
        Next

        'Affiche le résultat
        Console.WriteLine(Resultat)

        'Pause
        Console.Read()
    End Sub

    Sub replaceString(s As String)
        Console.WriteLine("Phrase avant remplacement : " & s)
        s = s.Replace("test", "testReplace")
        Console.WriteLine("Phrase après remplacement : " & s)
    End Sub

    Sub upperString(s As String)
        Console.WriteLine("Phrase avant majuscule : " & s)
        s = s.ToUpper
        Console.WriteLine("Phrase après majuscule : " & s)
        Console.WriteLine()
        Console.WriteLine("Phrase avant miniscule : " & s)
        s = s.ToLower
        Console.WriteLine("Phrase après miniscule : " & s)
    End Sub

    Sub manipDate(d As Date)
        Console.WriteLine("Manip Date ToShortDateString sur Date.Now : " & d.ToShortDateString())
        Console.WriteLine("Manip Date ToShortTimeString sur Date.Now : " & d.ToShortTimeString())
    End Sub

    Sub heureComplete(d As Date)
        Dim hComplete As String = d.ToLongTimeString
        Console.WriteLine(hComplete)
    End Sub

    Sub manipTabs()
        tabInt(0) = 10
        tabInt(4) = 15
        tabInt2D(0, 0) = 10
        tabInt3D(2, 3, 4) = 10
        Console.WriteLine("Taille du tableau tabInt avant ReDim = " & tabInt.Length)
        Console.WriteLine("Valeur contenue dans l'index 0 du tabInt avant ReDim = " & tabInt(0))
        'Redimensionner le tableau en réinitialisant les valeurs
        ReDim tabInt(20)
        Console.WriteLine("Taille du tableau tabInt après ReDim = " & tabInt.Length)
        Console.WriteLine("Valeur contenue dans l'index 0 du tabInt après ReDim = " & tabInt(0))
        tabInt(0) = 10
        tabInt(10) = 20
        tabInt(20) = 30
        Console.WriteLine("Valeurs attribuées au tableau modifiée : ")
        Console.WriteLine("Valeur de tabInt index 0 = " & tabInt(0))
        Console.WriteLine("Valeur de tabInt index 10 = " & tabInt(10))
        Console.WriteLine("Valeur de tabInt index 20 = " & tabInt(20))
        Console.WriteLine("Appuyer sur une touche pour continuer...")
        Console.ReadLine()
        Console.WriteLine("Taille du tableau tabInt avant ReDim Preserve = " & tabInt.Length)
        Console.WriteLine("Valeur contenue dans l'index 0 du tabInt avant ReDim Preserve = " & tabInt(0))
        'Redimensionner le tableau en gardant les valeurs
        ReDim Preserve tabInt(40)
        Console.WriteLine("Appuyer sur une touche pour continuer...")
        Console.ReadLine()
        Console.WriteLine("Taille du tableau tabInt après ReDim Preserve = " & tabInt.Length)
        Console.WriteLine("Valeur contenue dans l'index 0 du tabInt après ReDim Preserve = " & tabInt(0))
        Console.WriteLine("")
        Console.WriteLine("Appuyer sur une touche pour continuer...")
        Console.ReadLine()
        Console.WriteLine("Valeurs de tabInt AVANT Reverse")
        'Boucle FOR de parcours du tableau en affichant chaque valeur
        For i As Integer = 0 To tabInt.Length - 1
            Console.WriteLine("Boucle FOR : Index = " & i & " Valeur = " & tabInt(i))
        Next
        'Boucle FOREACH de parcours du tableau en affichant chaque valeur supérieure à 0
        For Each valTab As Integer In tabInt
            If valTab > 0 Then
                Console.WriteLine("Boucle FOR EACH : Valeur = " & valTab)
            End If
        Next
        'Inverser le tableau
        Array.Reverse(tabInt)
        Console.WriteLine("Valeurs de tabInt APRES Reverse")
        'Boucle FOR de parcours du tableau en affichant chaque valeur
        For i As Integer = 0 To tabInt.Length - 1
            Console.WriteLine("Index = " & i & " Valeur = " & tabInt(i))
        Next
        'Vider le tableau tabInt de l'index 0 à 10
        Array.Clear(tabInt, 0, 10)
        Console.WriteLine("Valeurs de tabInt APRES Clear de l'index 0 à index+10")
        'Boucle FOR de parcours du tableau en affichant chaque valeur
        For i As Integer = 0 To tabInt.Length - 1
            Console.WriteLine("Index = " & i & " Valeur = " & tabInt(i))
        Next
        Console.WriteLine("Appuyer sur une touche pour continuer...")
        Console.ReadLine()
        Console.WriteLine("Copie des valeurs du tableau tabInt dans tabInt2")
        Array.Copy(tabInt, tabInt2, tabInt2.Length)
        Console.WriteLine("Valeurs de tabInt2 APRES Copy du tabInt")
        For i As Integer = 0 To tabInt2.Length - 1
            Console.WriteLine("Index = " & i & " Valeur = " & tabInt2(i))
        Next
        Console.WriteLine("Appuyer sur une touche pour continuer...")
        Console.ReadLine()

        Console.WriteLine("TP Comptage de nombres")
        Dim MonTableau(50), Nombres(10), NumeroTrouve As Integer
        For i As Integer = 0 To MonTableau.Length - 1
            MonTableau(i) = Rnd(1) * 10
        Next

        'Initialisation Nombres[] avec des 0
        For i = 0 To Nombres.Length - 1
            Nombres(i) = 0
        Next

        'Comptage
        Console.WriteLine("Comptage des nombres dans le tableau")
        For i = 0 To MonTableau.Length - 1
            'Entre la valeur trouvée dans une variable intermédiaire
            NumeroTrouve = MonTableau(i)
            'Ajoute 1 à la case correspondant au numéro
            Nombres(NumeroTrouve) = Nombres(NumeroTrouve) + 1
        Next

        'Affichage des résultats
        For i = 0 To Nombres.Length - 1
            Console.WriteLine("Nombre de " & i & " trouvés : " & Nombres(i))
        Next
    End Sub

    Sub triTabs()
        Dim MonTableau(20), Intermediaire, TailleTableau As Integer
        Dim EnOrdre As Boolean = False

        'Remplir de nombres aléatoires
        For i As Integer = 0 To MonTableau.Length - 1
            MonTableau(i) = Rnd(1) * 10
        Next

        'Tri à bulles
        TailleTableau = MonTableau.Length
        While Not EnOrdre
            EnOrdre = True
            For i = 0 To TailleTableau - 2
                If MonTableau(i) > MonTableau(i + 1) Then
                    Intermediaire = MonTableau(i)
                    MonTableau(i) = MonTableau(i + 1)
                    MonTableau(i + 1) = Intermediaire
                    EnOrdre = False
                End If
            Next
            TailleTableau = TailleTableau - 1
        End While

        'Affichage des résultats
        For i = 0 To MonTableau.Length - 1
            Console.Write(" " & MonTableau(i))
        Next

    End Sub

    Sub Main()

        Do
            affichageMenus()
            Try
                choice = CInt(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Entrer un entier valide")
            End Try

            Select Case choice
                Case 1
                    Console.WriteLine("")
                    helloWorld()
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 2
                    Console.WriteLine("")
                    Console.WriteLine("- Addition de deux nombres -")
                    'Demande du premier nombre
                    Console.WriteLine("Premier nombre à additionner")
                    Try
                        val1 = Int16.Parse(Console.ReadLine())
                    Catch ex As Exception
                        Console.WriteLine("Entrer un entier valide")
                    End Try
                    'Demande du second nombre
                    Console.WriteLine("Second nombre à additionner")
                    Try
                        val2 = Int16.Parse(Console.ReadLine())
                    Catch ex As Exception
                        Console.WriteLine("Entrer un entier valide")
                    End Try
                    result = addition(val1, val2)
                    Console.WriteLine("Resultat de " & val1 & " + " & val2 & " = " & result)
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 3
                    Console.WriteLine("")
                    Console.WriteLine("- Multiplication de deux nombres -")
                    'Demande du premier nombre
                    Console.WriteLine("Premier nombre à multiplier")
                    Try
                        val1 = Int16.Parse(Console.ReadLine())
                    Catch ex As Exception
                        Console.WriteLine("Entrer un entier valide")
                    End Try                    'Demande du second nombre
                    Console.WriteLine("Second nombre à multiplier")
                    Try
                        val2 = Int16.Parse(Console.ReadLine())
                    Catch ex As Exception
                        Console.WriteLine("Entrer un entier valide")
                    End Try
                    result = multiplication(val1, val2)
                    Console.WriteLine("Resultat de " & val1 & " X " & val2 & " = " & result)
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 4
                    Console.WriteLine("")
                    replaceString(testString)
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 5
                    Console.WriteLine("")
                    upperString(testString)
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 6
                    Console.WriteLine("")
                    manipDate(Date.Now)
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 7
                    Console.WriteLine("")
                    Console.WriteLine("Afficher heure actuelle complète")
                    heureComplete(Date.Now)
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 8
                    Console.WriteLine("")
                    Console.WriteLine("Manipulation de tableaux")
                    manipTabs()
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 9
                    Console.WriteLine("")
                    Console.WriteLine("Tri de tableaux")
                    triTabs()
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 10
                    Console.WriteLine("")
                    Console.WriteLine("Remplir tableau et additionner les valeurs contenues")
                    fillTabAndAddValues()
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()

                Case 11
                    Console.WriteLine("")
                    Console.WriteLine("Création et utilisation de structures")
                    'Déclare une simple structure
                    'Dim MaStructure As FicheLivre
                    'Déclare un tableau de structure
                    Dim MonTableauDeStructure(9) As FicheLivre
                    Dim idLivre As Integer
                    MonTableauDeStructure(0).ID = 0
                    MonTableauDeStructure(0).Titre = "Les Misérables"
                    MonTableauDeStructure(0).Auteur = "Victor Hugo"
                    MonTableauDeStructure(0).Genre = "Roman"

                    MonTableauDeStructure(1).ID = 1
                    MonTableauDeStructure(1).Titre = "Gatsby le Magnifique"
                    MonTableauDeStructure(1).Auteur = "F. Scott Fitzgerald"
                    MonTableauDeStructure(1).Genre = "Roman"

                    MonTableauDeStructure(2).ID = 2
                    MonTableauDeStructure(2).Titre = "Astérix le Gaulois"
                    MonTableauDeStructure(2).Auteur = "René Goscinny"
                    MonTableauDeStructure(2).Genre = "Bande dessinée"

                    For i As Integer = 0 To 9
                        Console.WriteLine("ID : " & MonTableauDeStructure(i).ID)
                        Console.WriteLine("Titre : " & MonTableauDeStructure(i).Titre)
                        Console.WriteLine("Auteur : " & MonTableauDeStructure(i).Auteur)
                        Console.WriteLine("Genre : " & MonTableauDeStructure(i).Genre)
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()
                Case 12
                    Console.WriteLine("")
                    Console.WriteLine("Utilisation du IIF (vérifier la présence de la lettre A dans un mot")
                    Console.WriteLine("")
                    Console.WriteLine("Veuillez entrer un mot")
                    Dim MaChaine As String = Console.ReadLine()
                    Dim Compteur As Integer = 0
                    For Each Caractere As String In MaChaine
                        If Caractere = "a" Then
                            Compteur = Compteur + 1
                        End If
                    Next
                    Console.WriteLine(IIf(Compteur > 0, "La lettre 'A' a été trouvée dans " & MaChaine & " et possède la lettre 'A' " & Compteur & " fois", "La lettre 'A' n'a pas été trouvée dans " & MaChaine))
                    Console.WriteLine("")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()
                Case 13
                    Console.WriteLine("")
                    Console.WriteLine("MsgBox & InputBox")
                    MsgBox("Je suis une MsgBox qui bloque votre système tant que vous n'avez pas répondu" & Chr(13) & " J'ai l'icône d'une croix rouge (critical) et mes boutons sont : Ok / Annuler" & Chr(13) & "Je vous souhaite un agréable vol sur notre compagnie ...", 4113, "TestMsgBox")
                    Console.WriteLine("")
                    InputBox("Je suis une InputBox !", "TestInputBox")
                    Console.WriteLine("Appuyer sur une touche pour continuer...")
                    Console.ReadLine()
                Case 14
                    Console.Clear()
                    Console.WriteLine("Pour quitter le programme, appuyer sur une touche...")
                    Console.ReadLine()

                Case Else
                    'Pause de 5 secondes avant le clear
                    System.Threading.Thread.Sleep(5000)
                    Console.Clear()
                    Console.WriteLine("Ce menu n'existe pas")
                    Console.WriteLine("")

            End Select
        Loop While choice <> 10
        choice = 0
    End Sub

End Module