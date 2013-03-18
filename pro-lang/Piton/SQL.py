#!-*- coding:utf-8 -*-

import sqlite3

vt = sqlite3.connect(":memory:")
im = vt.cursor()

im.execute("""CREATE TABLE personel_giris(kullanici_adi, parola)""")

veriler = {}
sayac = 0
max = 1
while sayac < max:
	kullanici = raw_input("Lütfen kaydınız yoksa kaydolun:")
	parola = raw_input("Lütfen parolanizi giriniz:")
	veriler[kullanici] = parola
	sayac += 1 

veriler = veriler.items()

for veri in veriler:
	im.execute("""INSERT INTO personel_giris VALUES (?,?)""", veri)
vt.commit()


kull = raw_input("Lütfen kullanici isminiz giriniz:")
par = raw_input("Lütfen parolanizi giriniz:")

im.execute("""SELECT * FROM personel_giris WHERE kullanici_adi = ? AND parola = ? """, (kull, par))

data = im.fetchone()
if data:
	print u"Programa  hosgeldiniz  %s"  %data[0]
else:
	print u"Parola veya kullnici adi yanlis"	

