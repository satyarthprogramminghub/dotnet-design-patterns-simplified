# .NET Design Patterns Simplified

Practical, clean, and easy-to-follow implementations of the most commonly used design patterns in **.NET 8 / .NET 9** with C#.

### Goal
Learn design patterns through **simple, realistic examples** (Order Management domain) without over-engineering or complex abstractions.

### Patterns (in recommended order)
1. **Singleton** → [src/Singleton](src/Singleton)
2. Factory Method
3. Abstract Factory
4. Builder
5. Dependency Injection
6. Repository
7. Unit of Work
8. Strategy
9. Observer
10. Decorator
11. Adapter
12. Facade
13. CQRS

### How to Run
- Open `dotnet-design-patterns-simplified.sln`
- Each pattern has a `ConsoleDemo` project — set it as startup project and run (`F5`)
- Code is kept intentionally simple and clean

### Domain
We use a simple **Order Management** theme:
- `Customer`, `Product`, `Order`, `OrderItem`

### Documentation
- [Series Overview](docs/series-overview.md)
- [Pattern Roadmap](docs/pattern-roadmap.md)
