internal static class UserRepository
{
    private static List<User> CACHE;

    public static List<Pessoa> Listar()
    {
        if (CACHE != null) return CACHE;

        CACHE = new List<User>();

        //Logica para retornar da base
    }
    public static void Inserir(User user)
    {
        if (CACHE == null) Listar();

        CACHE.Add(user);
    }

    public static void Atualizar(User user)
    {
        if (CACHE == null) Listar();

        var userExists = CACHE.FirstOrDefault(p => p.Id.Equals(user.Id));
        CACHE.Remove(userExists);

        Inserir(user);
    }

}