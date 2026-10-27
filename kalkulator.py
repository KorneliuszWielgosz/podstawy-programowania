
liczba1 = float(input("Podaj pierwsza liczbe: "))
liczba2 = float(input("Podaj druga liczbe: "))
dzialanie = input("Wybierz dzialanie (+, -, *, /): ")

if dzialanie == "+":
    print("Wynik:", liczba1 + liczba2)
elif dzialanie == "-":
    print("Wynik:", liczba1 - liczba2)
elif dzialanie == "*":
    print("Wynik:", liczba1 * liczba2)
elif dzialanie == "/":
    if liczba2 == 0:
        print("Blad: nie mozna dzielic przez zero.")
    else:
        print("Wynik:", liczba1 / liczba2)
else:
    print("Nieprawidlowe dzialanie.")
