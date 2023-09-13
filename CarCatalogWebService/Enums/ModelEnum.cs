namespace CarCatalogWebService.Enums;

public class ModelEnum : BaseEnum<ModelEnum, Guid>
{
    public static ModelEnum EClass { get; } =
        new(Guid.Parse("dd37b872-ee3d-4c5a-8d61-e29a070131b6"), "E Class");

    public static ModelEnum SClass { get; } =
        new(Guid.Parse("85d8b4a8-d7cd-486b-89be-830e365e2ef1"), "S Class");

    public static ModelEnum GLClass { get; } =
        new(Guid.Parse("78d8b01a-ff21-42cc-a01f-d7e5e7440397"), "Gl Class");

    public static ModelEnum Corolla { get; } =
        new(Guid.Parse("8af872bf-2fce-49e4-9646-585de2b13b4e"), "Corolla");

    public static ModelEnum Camry { get; } =
        new(Guid.Parse("a798c5ee-b580-4e6c-a85f-e5cd72cae460"), "Camry");

    public static ModelEnum RAV4 { get; } =
        new(Guid.Parse("71c0a0fb-3bcd-4210-8948-56f043aa3c9d"), "RAV4");

    public static ModelEnum X5 { get; } =
        new(Guid.Parse("64189f5f-fe45-4cee-8904-d37a9036383f"), "X5");

    public static ModelEnum X6 { get; } =
        new(Guid.Parse("13d243fd-d0ab-4ed9-98b4-b5a83cf55156"), "X6");

    public static ModelEnum X7 { get; } =
        new(Guid.Parse("c0629ebf-4028-4946-9cd1-4151149b8421"), "X7");

    protected ModelEnum(Guid val, string name) : base(val, name)
    {
    }
}