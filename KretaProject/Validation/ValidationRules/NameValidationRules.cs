using System.Text.RegularExpressions;

namespace KretaProject.Validation.ValidationRules
{
    public class NameValidationRules
    {
        private static readonly Regex ValidNamePattern = new Regex("^[a-zA-ZáéíóöőúüűÁÉÍÓÖŐÚÜŰ\\-\\s]+$", RegexOptions.Compiled);
        private readonly string _nameToValidate;
        public NameValidationRules(string name)
        {
            _nameToValidate = name;
        }

        public bool IsNameShort => _nameToValidate.Length < 2;
        public bool IsValidCharacters => ValidNamePattern.IsMatch(_nameToValidate);
    }

    /*
^ (karetszimbólum) – A kifejezés elejét jelöli, azaz a minta a teljes bemenetre érvényes kell legyen.
[a-zA-Z\-\s] – Egy karakterhalmazt definiál:

    a-zA-Z – Csak az angol kis- és nagybetűket engedi meg.
    ^[a-zA-ZáéíóöőúüűÁÉÍÓÖŐÚÜŰ\-\\s]+$ – Most már a magyar ékezetes karaktereket (áéíóöőúüűÁÉÍÓÖŐÚÜŰ) is elfogadja.
    \- – A kötőjelet (-) is elfogadja.
    \s – A szóközöket is megengedi.

+ (pluszjel) – Legalább egy karaktert meg kell adni, és tetszőleges hosszúságú lehet.
$ (dollárjel) – A kifejezés végét jelöli, biztosítva, hogy csak a megengedett karakterek szerepelhetnek a teljes bemenetben.
     * 
     */
}
