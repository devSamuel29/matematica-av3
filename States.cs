using System.Text.RegularExpressions;

namespace Trabalho_matemática;

public static class States
{
    private static Regex regexMatoGrosso1 = new Regex(RegexStates.MATO_GROSSO_REGEX_1);
    private static Regex regexMatoGrosso2 = new Regex(RegexStates.MATO_GROSSO_REGEX_2);
    private static Regex regexMatoGrossoSul1 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_1);
    private static Regex regexMatoGrossoSul2 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_2);
    private static Regex regexMatoGrossoSul3 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_3);
    private static Regex regexTocantins1 = new Regex(RegexStates.TOCANTINS_REGEX_1);
    private static Regex regexTocantins2 = new Regex(RegexStates.TOCANTINS_REGEX_2);
    private static Regex regexTocantins3 = new Regex(RegexStates.TOCATINS_REGEX_3);

    public static string getState(string plate)
    {
        if (regexMatoGrosso1.IsMatch(plate) || regexMatoGrosso2.IsMatch(plate))
        {
            return "Mato Grosso";
        }
        else if (
            regexMatoGrossoSul1.IsMatch(plate)
            || regexMatoGrossoSul2.IsMatch(plate)
            || regexMatoGrossoSul3.IsMatch(plate)
        )
        {
            return "Mato Grosso do Sul";
        }
        else if (
            regexTocantins1.IsMatch(plate)
            || regexTocantins2.IsMatch(plate)
            || regexTocantins3.IsMatch(plate)
        )
        {
            return "Tocantins";
        }
        return "Estado não cadastrado";
    }
}
