algoritmo "posto JLCM"
// Função :Calcular o preço do combustível
// Autor :João Lucas e Cauã M
// Data : 08/03/2023
// Seção de Declarações 
var
cod:caracter
quant,V1,V2:real
inicio
escreva("Digite o tipo de combustível: ")
leia(cod)
escreva("Digite a quantidade de litros: ")
leia(quant)
 se(cod = "A")entao
    se(quant <= 20)entao
V1:=4.90-(4.90*3)/100
V2:=V1*quant
escreva(V2)
    senao
 se(quant>20)entao
 V1:=4.90-(4.90*5)/100
 V2:=V1*quant
escreva(V2)
fimse
fimse
 senao
se(cod="G")entao
  se(quant<=20)entao
V1:=5.50-(5.50*4)/100
V2:=V1*quant
escreva(V2)
  senao
  se(quant>20)entao
V1:=5.50-(5.50*6)/100
V2:=V1*quant
escreva(V2)
senao
escreva("inválido")
   fimse
  fimse
 fimse
fimse
fimalgoritmo
