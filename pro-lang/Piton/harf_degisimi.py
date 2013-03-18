#! -*- coding:utf-8 -*-

def harf_degisimi(kelime, ch, yeni_ch):
	yeni = ""
	for harf in kelime:
		if harf == ch:
			yeni += yeni_ch
		else:
			yeni += harf
