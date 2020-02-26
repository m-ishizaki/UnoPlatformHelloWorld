namespace UnoApp1.Shared
{
    class MainPageViewModeBindingBase : BindingBase
    {
        string _box21;
        public string Box21 { get => _box21; set { if (SetProperty(ref _box21, value)) OnChanged(); } }
        string _box22;
        public string Box22 { get => _box22; set { if (SetProperty(ref _box22, value)) OnChanged(); } }

        string _block21;
        public string Block21 { get => _block21; set => SetProperty(ref _block21, value); }

        void OnChanged() => Block21 = $"{Box21}{Box22}";
    }
}