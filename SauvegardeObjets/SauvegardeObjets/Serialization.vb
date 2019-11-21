Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Xml.Serialization

Module Serialization

    Sub Main()

        'Création objets Film et tableau Films de taille 2
        Dim Films(1) As Film
        Dim troisCent As Film = New Film("300", 2006, "300, film de Zack Snyder sorti en Mars 2007")
        Films(0) = New Film("Avatar", 2009, "Avatar, film de James Cameron sorti en Décembre 2009.")
        Films(1) = New Film("Twilight 3", 2010, "Troisième volet de la quadrilogie Twilight")

        serializationBinaire(troisCent)
        'deserializationBinaire()

        serializationXML(Films(1))
        'deserializationXML()

        serializationXMLTab(Films)
        deserializationXMLTab()
    End Sub

    Sub serializationBinaire(film As Film)
        'Serialisation

        'Création fichier et récupération flux
        Dim FluxFichier As FileStream = File.Create("Film.bin")
        Dim Serializer As New BinaryFormatter

        'Serialisation et écriture
        Serializer.Serialize(FluxFichier, film)

        'Fermeture flux
        FluxFichier.Close()
    End Sub

    Sub deserializationBinaire()
        'Déserialisation

        'Vérification si le fichier existe
        If File.Exists("Film.bin") Then

            'Création classe vide
            Dim film As New Film()

            'Ouverture fichier et récupération flux
            Dim FluxFichier As FileStream = File.OpenRead("Film.bin")
            Dim Deserializer As New BinaryFormatter()

            'Désérialisation et conversion des données récupérées dans le type "Film"
            film = CType(Deserializer.Deserialize(FluxFichier), Film)

            'Fermeture flux
            FluxFichier.Close()
        End If
    End Sub

    Sub serializationXML(film As Film)
        'Serialisation

        'Création fichier et récupération flux
        Dim FluxFichier As FileStream = File.Create("Film.xml")
        Dim Serializer As New XmlSerializer(GetType(Film))

        'Serialisation et écriture
        Serializer.Serialize(FluxFichier, film)

        'Fermeture flux
        FluxFichier.Close()
    End Sub

    Sub deserializationXML()
        'Vérification si le fichier existe
        If File.Exists("Film.xml") Then

            'Création classe vide
            Dim film As New Film()

            'Ouverture fichier et récupération flux
            Dim FluxFichier As FileStream = File.OpenRead("Film.xml")
            Dim Deserializer As New XmlSerializer(GetType(Film))

            'Désérialisation et conversion des données récupérées dans le type "Film"
            film = CType(Deserializer.Deserialize(FluxFichier), Film)

            'Fermeture flux
            FluxFichier.Close()
        End If
    End Sub

    Sub serializationXMLTab(films As Film())
        'Serialisation

        'Création fichier et récupération flux
        Dim FluxFichier As FileStream = File.Create("Films.xml")
        Dim Serializer As New XmlSerializer(GetType(Film()))

        'Serialisation et écriture
        Serializer.Serialize(FluxFichier, films)

        'Fermeture flux
        FluxFichier.Close()
    End Sub

    Sub deserializationXMLTab()
        'Vérification si le fichier existe
        If File.Exists("Films.xml") Then

            'Ouverture fichier et récupération flux
            Dim FluxFichier As FileStream = File.OpenRead("Films.xml")
            Dim Deserializer As New XmlSerializer(GetType(Film()))

            'Désérialisation et conversion des données récupérées dans le type "Film"
            Dim Films() As Film = Deserializer.Deserialize(FluxFichier)

            'Fermeture flux
            FluxFichier.Close()
        End If
    End Sub

End Module
