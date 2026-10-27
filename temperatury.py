print("KONWERTER TEMPERATUR")
print("Wpisz C, aby przeliczyc Celsjusze na Fahrenheity.")
print("Wpisz F, aby przeliczyc Fahrenheity na Celsjusze.")

skala = input("Wybierz skale (C/F): ").upper()
temperatura = float(input("Podaj temperature: "))

if skala == "C":
    wynik = temperatura * 1.8 + 32
    print("Temperatura w Fahrenheitach:", wynik)
elif skala == "F":
    wynik = (temperatura - 32) / 1.8
    print("Temperatura w Celsjuszach:", wynik)
else:
    print("Nieprawidlowy wybor skali.")