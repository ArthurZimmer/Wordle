# TERMO-no-console
Você já ouviu falar no jogo TERMO, ou até mesmo Wordle? Isso mesmo! Esses exatos mesmos jogos totalmente programados em C, aonde o usuário tem contato diretamente pelo console.

Acertando a letra, aparecerá "*". Caso a letra pertença a palavra mas está no lugar errado, aparecerá "+". Se a letra não estiver contida na palavra, continuará aparecendo "_".

    #include <stdio.h>
    #include <string.h>
    
    int main() {
        printf("Bem vindo ao ZimmerWord! Estou pensando em uma palavra de 5 letras, você terá 6 tentativas para adivinhar qual é. Boa sorte!\n\n\n");

    char palavra[6] = "fotos";
    char tentativa[6];
    int i, j, correta = 0, tentativas = 0;

    for (i = 0; i < 6; i++) {
        tentativa[i] = '_';
    }

    do {
        printf("\n\nDigite a palavra: \n\n");
        scanf("%s", tentativa);
        tentativas++;

        if (strcmp(tentativa, palavra) == 0) {
            correta = 1;
            break;
        } else {
            for (i = 0; i < 5; i++) {
                if (tentativa[i] == palavra[i]) {
                    printf("* ");
                } else {
                    int achou = 0;
                    for (j = 0; j < 5; j++) {
                        if (tentativa[i] == palavra[j] && i != j) {
                            printf("+ ");
                            achou = 1;
                            break;
                        }
                    }
                    if (!achou) {
                        printf("_ ");
                    }
                }
            }
        }

    } while (tentativas < 6); 

    if (correta) {
        printf("\n\nParabéns! Você acertou a palavra.\n");
    } else {
        printf("\n\nSuas tentativas acabaram. A palavra correta era: %s\n", palavra);
    }

    return 0;
    }
