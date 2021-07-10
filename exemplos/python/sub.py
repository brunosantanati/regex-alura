# Para executar esse programa, no diretório onde ele se encontra rodar:
# "C:\Users\myuser\Documents\apps\python-3.9.5-embed-amd64\python" sub.py

import re

regex = '\s-\s'
novotexto = ': '
alura = 'Alura - Regex'
resultado = re.sub(regex, novotexto, alura)
print(resultado)

regex = '-'
novotexto = '/'
alvo = '2007-12-31'
resultado = re.sub(regex, novotexto, alvo)
print(resultado)