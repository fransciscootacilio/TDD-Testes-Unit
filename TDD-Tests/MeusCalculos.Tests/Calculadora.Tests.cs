using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeusCalculos;

namespace MeusCalculos.Tests
{
    public class CalculadoraTests
    {
        
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestarSomaDeDoisNumeros(int num1, int num2, int resultado)
        {
            // Given
            Calculadora calc = new Calculadora();
        
            // When
            int resultadoCalculadora = calc.somar(num1, num2);
        
            // Then
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(6, 5, 1)]
        public void TestarSubtraiDoisNumeros(int num1, int num2, int resultado)
        {
            // Given
            Calculadora calc = new Calculadora();
        
            // When
            int resultadoCalculadora = calc.subtrair(num1, num2);
        
            // Then
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestarMultiplicaDoisNumeros(int num1, int num2, int resultado)
        {
            // Given
            Calculadora calc = new Calculadora();
        
            // When
            int resultadoCalculadora = calc.mutiplicar(num1, num2);
        
            // Then
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        public void TestarDivisaoDeDoisNumeros(int num1, int num2, int resultado)
        {
            // Given
            Calculadora calc = new Calculadora();
        
            // When
            int resultadoCalculadora = calc.dividir(num1, num2);
        
            // Then
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            // Given
            Calculadora calc = new Calculadora();
        
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            // Given
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(2, 2);
            calc.somar(3, 2);
            calc.somar(3, 4);

            var lista = calc.historico();
        
            // Then

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}