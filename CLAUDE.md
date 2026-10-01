# CLAUDE.md — Paws Place v2

## O que é o projeto

Site de adoção de animais (gatos e cachorros). Começou como projeto de extensão da
faculdade em HTML/CSS/JS puro e agora está sendo **reconstruído para aprendizado**:
back em **.NET 10 (ASP.NET Core Web API)** e front em **Angular 20**. Não há deploy
nem uso real: o objetivo é o Vini (dev Jr/trainee) entender cada peça.

O Vini trabalha com o mesmo stack (back .NET em camadas PierBack / PierService /
PierRepository e front Angular 20). Sempre que um conceito daqui tiver paralelo
com o trabalho, aponte o paralelo.

## Modo guiado (como conduzir)

- **Um passo curto por vez.** Explique o que vai fazer e **por quê** antes de mudar código.
- **Divisão de trabalho:**
  - Claude faz: setup, boilerplate e configuração (csproj, DI, Program.cs, proxy, tsconfig).
  - O Vini escreve: o corpo das regras (ações de controller, métodos de service, queries
    de repository, lógica de componente) **nas primeiras vezes de cada padrão**. Dê dicas
    e o "esqueleto" com a assinatura, mas não o corpo pronto. Depois revise o que ele fez.
- Não preencha lacuna de regra de negócio por conta própria: pergunte e liste casos-limite.
- Respostas curtas (mire em ~40 linhas). Comece pelo que trava o próximo passo.
- **Ao concluir uma etapa do roadmap, registre-a em `docs/HISTORICO-V2.md`** (entrada no
  topo, seguindo o modelo do arquivo): o que foi feito + os **principais** aprendizados,
  curto (até ~15 linhas). Marque também o checkbox em `docs/ROADMAP-V2.md`. Peça ao Vini
  para revisar/complementar os aprendizados com as palavras dele. Não pule este passo.
- Feche cada passo com:
  ```
  ✅ Feito: ...
  ⏭️ Próximo passo: ...
  ⚠️ Pendências: ...
  ```

## Estrutura

```
src/                       # back v2 (.NET 10)
├── PawsPlace.Domain/      # entidades + enums. Não depende de ninguém.
├── PawsPlace.Repository/  # EF Core: AppDbContext, configurações, repositórios, migrations
├── PawsPlace.Service/     # regras de negócio, DTOs, exceções de domínio
├── PawsPlace.Api/         # controllers finos, Program.cs, tratamento global de erros
└── PawsPlace.Tests/       # xUnit
web/                       # front v2 (Angular 20)
docs/ROADMAP-V2.md         # checklist das etapas da reconstrução
docs/HISTORICO-V2.md       # registro por etapa: o que foi feito + principais aprendizados
```

Dependências em uma única direção: `Api → Service → Repository → Domain`.
- **Controller** só traduz HTTP ↔ chamada de service (sem regra, sem EF, sem try/catch).
- **Service** contém a regra de negócio e lança exceções de domínio.
- **Repository** é o único lugar que conhece o EF Core / banco.

### Código legado (somente consulta, não editar)
- `backend/PawsPlace.Api/` — back antigo (.NET 8, gerado por IA, tudo no controller, `EnsureCreated`).
- `*.html`, `scripts/`, `styles/`, `tests/` na raiz — front vanilla antigo.
Use como referência de regras e dados (ex.: `backend/PawsPlace.Api/Data/Seed.cs`).
Só remover na Etapa 11, com confirmação do Vini.

## Convenções

- **Idioma:** português em nomes de classes, métodos, variáveis, rotas e mensagens
  (`AnimalService.ListarAsync`, `/api/animais`). Termos técnicos do framework ficam em inglês.
- **Back:** nullable habilitado; métodos assíncronos com sufixo `Async`; DTOs como `record`;
  injeção por construtor primário; banco SQLite com **migrations** (nunca `EnsureCreated`);
  segredos em `dotnet user-secrets`, nunca em `appsettings.json`.
- **Front:** standalone components, modo estrito, sem `any`; estado em serviços com
  Observables (sem NgRx); Reactive Forms.
- **Git:** Conventional Commits em português (`feat: adiciona filtro por porte`).
  Branch de trabalho: `v2`. Nunca commitar, fazer push ou apagar arquivos sem pedido explícito.

## Ferramentas (igual ao trabalho)

- **Back:** Visual Studio 2026, abrindo `src/PawsPlace.slnx` (F5 → perfil `http` → abre o Scalar).
  Ao dar instruções de back, prefira os caminhos do VS (Gerenciador de Soluções, F5, `.http`).
- **Front:** VS Code, abrindo a pasta `web/`.

## Comandos

```bash
dotnet build src/PawsPlace.slnx
dotnet test src/PawsPlace.slnx
dotnet run --project src/PawsPlace.Api        # API + Scalar em /scalar
cd web && ng serve                            # front com proxy para /api
```
