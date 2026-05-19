PROJETO FINAL: MEU PRIMEIRO AMBIENTE VR INTERATIVO
Residência em TIC 29 - Web 3.0 | Unidade 1 - Capítulo 3

ALUNO(A): Maria de Fátima Altarugio de Oliveira
CPF: 141.37.616-08
LINK DO REPOSITÓRIO: https://github.com/fatimaaltarugio-max/Projeto-Metaverso-Interativo-TIC29

1. APRESENTAÇÃO DO PROJETO
Foi desenvolvido um ambiente virtual tridimensional utilizando o motor gráfico Unity 6, simulando uma Célula de Treinamento e Integração de RH para Linhas de Produção Industrial no Metaverso. O espaço conta com um galpão virtual contendo postos de trabalho simulados por formas tridimensionais (maquinários, esteiras e bancadas de ferramentas).

2. CONTEXTO E OBJETIVOS (METAVERSO)
O ambiente se insere no contexto de Treinamento Corporativo, Simulação Industrial e Integração de RH. O objetivo é permitir que novos colaboradores passem por um treinamento imersivo de montagem e manutenção antes de irem para a fábrica real. Através da simulação nos postos, o sistema avalia a aptidão técnica do operador, permitindo que o RH distribua as pessoas nas linhas de montagem onde demonstraram melhor desempenho, mitigando riscos de acidentes e otimizando a produtividade.

3. INTERAÇÃO IMPLEMENTADA
Foi desenvolvido um script em C# ("MudancaDeCor1.cs") atrelado à "Peça de Teste" na bancada principal. Ao interagir e clicar com o mouse sobre a peça, ela altera sua cor de material em tempo real. Essa mecânica simula o sucesso na atividade de montagem/conserto do item (indicando visualmente que o posto foi concluído pelo operador em treinamento).

4. INSTRUÇÕES DE NAVEGAÇÃO E TESTE (PC EDITOR)
- Olhar ao redor: Segure o botão DIREITO do mouse na aba Scene e movimente o cursor.
- Zoom: Utilize a rodinha do mouse (Scroll).
- Interação: Ative o modo "Play", vá até a aba "Game" e clique com o botão ESQUERDO do mouse em cima da peça (Peca_De_Teste) para iniciar a simulação de conserto e vê-la mudar de cor.

5. PROCESSO DE CRIAÇÃO E DIFICULDADES
O projeto utilizou o Meta XR SDK no Unity 6. A maior dificuldade foi criar um design conceitual claro usando primitivos que representassem de forma coerente uma simulação de RH para fábrica. O desafio foi resolvido mapeando formas geométricas básicas como maquinários industriais e aplicando funções de colisão via C# (OnMouseDown) para registrar os comandos de teste do PC, simulando a dinâmica prática sem dependência do headset físico.
