Princípios SOLIDS utilizados no código:

SRP - Single Responsability Principle:
  Utilizamos no código classes únicas com objetivos específicos.
OCP - Open Closed Principle:
  Utilizamos interfaces (campo fechado para modificações) e criamos classes que herdarão o contrato de interface (campo aberto para modificações).
LSP -  Liskov Substitution Principle
  Removemos a classe pai, que fazia com que todas as outras classes dependessem dela. Implementamos uma interface para substituir
  o método que foi criado nessa classe anteriormente.
ISP – Interface Segregation Principle
  Nossas interfaces contém métodos objetivos e poucos deles, tornando assim uma aplicação com interfaces mais coesas.
