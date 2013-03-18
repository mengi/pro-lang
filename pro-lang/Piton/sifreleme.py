def sifrele(harf):
    harfler ="abcdefghijklmnopqrstuvwxyz"
    if harf in harfler:
        harf = harfler[(harfler.index(harf) + 2) % len(harfler)]
        print harf

sifrele("z")        


def sifreleme(kelime):
	yeni = ""
	harfler ="abcdefghijklmnopqrstuvwxyz"
	for harf in kelime:
		if harf in harfler:
			harf = harfler[(harfler.index(harf) + 2) % len(harfler)]
			yeni += harf
	print yeni		 

sifreleme("denr")

