DESCRIPTION

Parfois, vous souhaitez avoir un schéma d'URL personnalisé comme alert: pour gérer certains liens personnalisés. Pour ce faire, vous pouvez enregistrer une application dans un schéma d'URI dans le registre et créer une application qui s'exécute pour gérer les demandes adressées à ce schéma d'URL.

L'application contient 2 projets :

1-Un projet d'installation de Visual Studio qui installe l'application.

2-Les paramètres de registre pour permettre à l'application Windows de gérer le protocole "alert:".

Vous souhaitez créer un schéma d'URL alert et avoir une application dans "C:\Program Files\Alert\alert.exe"  dont vous souhaitez gérer le schéma d'URL avec votre application. Ensuite, vous devez créer ces clés et valeurs dans le registre.

    [HKEY_CLASSES_ROOT\alert]
    "URL Protocol"="\"\""
    @="\"URL:Alert Protocol\""

    [HKEY_CLASSES_ROOT\alert\DefaultIcon]
    @="\"alert.exe,1\""

    [HKEY_CLASSES_ROOT\alert\shell]

    [HKEY_CLASSES_ROOT\alert\shell\open]

    [HKEY_CLASSES_ROOT\alert\shell\open\command]
    @="\"C:\\Program Files\\Alert\\alert.exe\" \"%1\""

Enregistrer un protocole URL personnalisé dans Windows
1. Allez dans Démarrer puis dans Rechercher type regedit -> il devrait ouvrir l'éditeur de registre.
2. Cliquez avec le bouton droit de la souris sur HKEY_CLASSES_ROOT puis sur Nouveau -> Clé
3. Dans la clé, donnez le nom en minuscule par lequel vous voulez que les URL soient appelées (dans mon cas, ce sera une alert) et la valeur d'alert interne (par défaut) change en "URL: Protocole d'alerte", puis cliquez avec le bouton droit de la souris sur l'alerte -> puis Nouveau -> Valeur de chaîne et ajoutez URL protocol sans valeur "".
4. Ensuite, ajoutez plus d'entrées comme vous l'avez fait avec le protocole (Right Mouse New -> Key) et créez une hiérarchie comme 
alert -> DefaultIcon et à l'intérieur de DefaultIcon changez la valeur (Default) en "alert.exe, 1", puis créez une hiérarchie comme
  alert -> shell -> open -> commande et la commande à l'intérieur du changement (par défaut) au chemin où .exe que vous voulez lancer est, pour ressembler à: "C:\Program Files\Alert\alert.exe" "%1"
5. Pour tester si cela fonctionne, allez dans Chrome ou Edge et entrez alert:C:/Users/Path/lancer.bat cela devrait déclencher votre fichier .bat et en browser 
href="alert:C:/Users/Path/lancer.bat"

Salam AL QAISSY
