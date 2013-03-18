def alfabetik_artan():
    ac = open('words.txt','r')
    for i in ac:
        liste=list(i)
        liste.pop()
        liste2=list(i)
        liste2.pop()
        liste2.sort()
        if liste2 == liste:
            i = i.strip()
            print i
            
    ac.close()     
