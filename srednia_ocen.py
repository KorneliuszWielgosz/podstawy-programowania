liczba_ocen = int(input("Ile ocen chcesz podac? "))

if liczba_ocen <= 0:
    print("Liczba ocen musi byc wieksza od zera.")
else:
    suma = 0

    for i in range(liczba_ocen):
        ocena = float(input(f"Podaj ocene {i + 1} (1-6): "))
        suma += ocena

    srednia = suma / liczba_ocen

    print("Srednia ocen:", round(srednia, 2))

    if srednia >= 3.0:
        print("Zaliczenie: TAK")
    else:
        print("Zaliczenie: NIE")