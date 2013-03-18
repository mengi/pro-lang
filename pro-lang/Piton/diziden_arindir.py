# -*- coding: utf-8 -*-

def diziden_arindir(kisa, uzun):
    while uzun.find(kisa) != -1:
        a = len(kisa)
        b = uzun.find(kisa)
        uzun = uzun[0:b] + uzun[a+b:]
	print uzun
