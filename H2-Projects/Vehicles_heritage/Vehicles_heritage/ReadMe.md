#Lav Kobling og Høj Samhørighed

Lav Kobling:
Lav kobling betyder at den første klasse ikke burde blive påvirket af ændringer i den anden klasse.

1: class Program, er den eneste lav kobling, da den ikk laver ændringer i andre klasser. 

Høj Kobling:
betyder f.eks. en klasse har brug for viden om hvordan en anden klasse er og en ændring i den anden
klasse kan påvirke den første klasse. Så at forstå den første klasse skal man også forstå den anden klasse.

1: class Vehicle
2: class og under classerne (Bus, Truck og PersonalCar)

Vi har høj kobling mellem dem da, hvis der bliver ændret noget i enten eller af dem, ændres det begge steder.

Samhørighed:
er når klasser og interfaces er håndterbare, forståelige samt skaber sammenhæng imellem ansvar, data og metoder.
Vi vil gerne have høj samhørighed da det gør det nemmere for os at forstå, genbruge og vedligeholde samt ændre kode.
betyder også at f.eks. en klasse kun har at gøre med en enkel ting, f.eks. bil og ikke bil samt højhus.

1: Vores Vehicle klasse samt "IBuyerModel" og "ISellerModel" interfaces, er høj samhørighed, 
da de skaber sammenhængen mellem f.eks. Users, og Bus, Truck, PassengerCar.



