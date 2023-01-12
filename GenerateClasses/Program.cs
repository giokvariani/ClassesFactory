using GenerateClasses.PowerSource;

var words = new string[] { "HonestTaxPayer", "Collection", "ObtainCollection","StopCollection", "StopCollectionAct",
    "CollectionConfirmation", "Lien", "ObtainLien", "StopLien", "NewPayer", "CheckPayer" };

ClassesFactory.Create(words);

//var childOfSources = Source.GetAllChild() ??
//    Enumerable.Empty<Type>().ToList().AsReadOnly();
