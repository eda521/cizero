# ExampleApp — Workshop

Cíl: natrénovat PR workflow, CI a unit testy.

Jak spustit lokálně:
1. `dotnet build`
2. `dotnet test`

Doporučený postup workshopu:
- Vytvoř feature branch: `git checkout -b feature/your-task`
- Implementuj, napiš testy.
- Spusť `dotnet test` lokálně.
- Pushni branch a otevři draft PR, sleduj CI.
- Self‑review podle checklistu v CONTRIBUTING.md a pak `squash merge`.

PR checklist (vložit do popisu PR):
- [ ] Popis změny / odkaz na issue
- [ ] Testy přidány / upraveny
- [ ] Lokální build a testy OK
- [ ] CI zelené