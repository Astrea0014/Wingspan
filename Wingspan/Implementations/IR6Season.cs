namespace Wingspan.Implementations
{
    interface ICustomGameParameter
    {
        public nuint Pointer { get; set; }
        public uint StaticIdentifier { get; }
        public string Name { get; }

        public Dictionary<uint, nuint> AllPointers { get; }
        public Dictionary<string, uint> AllStaticIdentifiers { get; }
    }

    interface IR6Season
    {
        public ICustomGameParameter Map { get; }
        public ICustomGameParameter TimeOfDay { get; }
        public ICustomGameParameter GameMode { get; }

        public void ActivateUnlockAll();
        public void DeactivateUnlockAll();
    }
}
