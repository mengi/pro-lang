#!/usr/bin/env python
#-*- coding: utf-8 -*-


def my_insert(indeks, eleman):
    liste = [1, 2, 3, 'a', 'b']
    print liste[:indeks] + list(eleman) + liste[indeks:]

my_insert(3, "2")
