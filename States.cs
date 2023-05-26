using System.Text.RegularExpressions;

namespace Trabalho_matemática;

public static class States
{
    private static Regex regexMatoGrosso1 = new Regex(RegexStates.MATO_GROSSO_REGEX_1);
    private static Regex regexMatoGrosso1Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_1_ANTIGA);
    private static Regex regexMatoGrosso2 = new Regex(RegexStates.MATO_GROSSO_REGEX_2);
    private static Regex regexMatoGrosso2Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_2_ANTIGA);
    private static Regex regexMatoGrosso3 = new Regex(RegexStates.MATO_GROSSO_REGEX_3);
    private static Regex regexMatoGrosso3Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_3_ANTIGA);
    private static Regex regexMatoGrosso4 = new Regex(RegexStates.MATO_GROSSO_REGEX_4);
    private static Regex regexMatoGrosso4Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_4_ANTIGA);
    private static Regex regexMatoGrosso5 = new Regex(RegexStates.MATO_GROSSO_REGEX_5);
    private static Regex regexMatoGrosso5Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_5_ANTIGA);
    private static Regex regexMatoGrosso6 = new Regex(RegexStates.MATO_GROSSO_REGEX_6);
    private static Regex regexMatoGrosso6Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_6_ANTIGA);
    private static Regex regexMatoGrosso7 = new Regex(RegexStates.MATO_GROSSO_REGEX_7);
    private static Regex regexMatoGrosso7Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_7_ANTIGA);
    private static Regex regexMatoGrosso8 = new Regex(RegexStates.MATO_GROSSO_REGEX_8);
    private static Regex regexMatoGrosso8Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_8_ANTIGA);
    private static Regex regexMatoGrosso9 = new Regex(RegexStates.MATO_GROSSO_REGEX_9);
    private static Regex regexMatoGrosso9Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_9_ANTIGA);
    private static Regex regexMatoGrosso10 = new Regex(RegexStates.MATO_GROSSO_REGEX_10);
    private static Regex regexMatoGrosso10Antiga = new Regex(
        RegexStates.MATO_GROSSO_REGEX_10_ANTIGA
    );
    private static Regex regexMatoGrosso11 = new Regex(RegexStates.MATO_GROSSO_REGEX_11);
    private static Regex regexMatoGrosso11Antiga = new Regex(RegexStates.MATO_GROSSO_REGEX_11);
    private static Regex regexMatoGrosso12 = new Regex(RegexStates.MATO_GROSSO_REGEX_12);
    private static Regex regexMatoGrosso12Antiga = new Regex(
        RegexStates.MATO_GROSSO_REGEX_12_ANTIGA
    );
    private static Regex regexMatoGrosso13 = new Regex(RegexStates.MATO_GROSSO_REGEX_13);
    private static Regex regexMatoGrosso13Antiga = new Regex(
        RegexStates.MATO_GROSSO_REGEX_13_ANTIGA
    );
    private static Regex regexMatoGrosso14 = new Regex(RegexStates.MATO_GROSSO_REGEX_14);
    private static Regex regexMatoGrosso14Antiga = new Regex(
        RegexStates.MATO_GROSSO_REGEX_14_ANTIGA
    );
    private static Regex regexMatoGrosso15 = new Regex(RegexStates.MATO_GROSSO_REGEX_15);
    private static Regex regexMatoGrosso15Antiga = new Regex(
        RegexStates.MATO_GROSSO_REGEX_15_ANTIGA
    );
    private static Regex regexMatoGrosso16 = new Regex(RegexStates.MATO_GROSSO_REGEX_16);
    private static Regex regexMatoGrosso16Antiga = new Regex(
        RegexStates.MATO_GROSSO_REGEX_16_ANTIGA
    );
    private static Regex regexMatoGrossoSul1 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_1);
    private static Regex regexMatoGrossoSul1Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_1_ANTIGA
    );
    private static Regex regexMatoGrossoSul2 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_2);
    private static Regex regexMatoGrossoSul2Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_2_ANTIGA
    );
    private static Regex regexMatoGrossoSul3 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_3);
    private static Regex regexMatoGrossoSul3Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_3_ANTIGA
    );
    private static Regex regexMatoGrossoSul4 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_4);
    private static Regex regexMatoGrossoSul4Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_4_ANTIGA
    );
    private static Regex regexMatoGrossoSul5 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_5);
    private static Regex regexMatoGrossoSul5Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_5_ANTIGA
    );
    private static Regex regexMatoGrossoSul6 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_6);
    private static Regex regexMatoGrossoSul6Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_6_ANTIGA
    );
    private static Regex regexMatoGrossoSul7 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_7);
    private static Regex regexMatoGrossoSul7Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_7_ANTIGA
    );
    private static Regex regexMatoGrossoSul8 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_8);
    private static Regex regexMatoGrossoSul8Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_8_ANTIGA
    );
    private static Regex regexMatoGrossoSul9 = new Regex(RegexStates.MATO_GROSSO_SUL_REGEX_9);
    private static Regex regexMatoGrossoSul9Antiga = new Regex(
        RegexStates.MATO_GROSSO_SUL_REGEX_9_ANTIGA
    );
    private static Regex regexTocantins1 = new Regex(RegexStates.TOCANTINS_REGEX_1);
    private static Regex regexTocantins1Antiga = new Regex(RegexStates.TOCANTINS_REGEX_1_ANTIGA);
    private static Regex regexTocantins2 = new Regex(RegexStates.TOCANTINS_REGEX_2);
    private static Regex regexTocantins2Antiga = new Regex(RegexStates.TOCANTINS_REGEX_2_ANTIGA);
    private static Regex regexTocantins3 = new Regex(RegexStates.TOCANTINS_REGEX_3);
    private static Regex regexTocantins3Antiga = new Regex(RegexStates.TOCANTINS_REGEX_3_ANTIGA);
    private static Regex regexTocantins4 = new Regex(RegexStates.TOCANTINS_REGEX_4);
    private static Regex regexTocantins4Antiga = new Regex(RegexStates.TOCANTINS_REGEX_4_ANTIGA);
    private static Regex regexTocantins5 = new Regex(RegexStates.TOCANTINS_REGEX_5);
    private static Regex regexTocantins5Antiga = new Regex(RegexStates.TOCANTINS_REGEX_5_ANTIGA);
    private static Regex regexTocantins6 = new Regex(RegexStates.TOCANTINS_REGEX_6);
    private static Regex regexTocantins6Antiga = new Regex(RegexStates.TOCANTINS_REGEX_6_ANTIGA);
    private static Regex regexTocantins7 = new Regex(RegexStates.TOCANTINS_REGEX_7);
    private static Regex regexTocantins7Antiga = new Regex(RegexStates.TOCANTINS_REGEX_7_ANTIGA);
    private static Regex regexTocantins8 = new Regex(RegexStates.TOCANTINS_REGEX_8);
    private static Regex regexTocantins8Antiga = new Regex(RegexStates.TOCANTINS_REGEX_8_ANTIGA);

    public static string getState(string plate)
    {
        if (
            regexMatoGrosso1.IsMatch(plate)
            || regexMatoGrosso2.IsMatch(plate)
            || regexMatoGrosso3.IsMatch(plate)
            || regexMatoGrosso4.IsMatch(plate)
            || regexMatoGrosso5.IsMatch(plate)
            || regexMatoGrosso6.IsMatch(plate)
            || regexMatoGrosso7.IsMatch(plate)
            || regexMatoGrosso8.IsMatch(plate)
            || regexMatoGrosso9.IsMatch(plate)
            || regexMatoGrosso10.IsMatch(plate)
            || regexMatoGrosso11.IsMatch(plate)
            || regexMatoGrosso12.IsMatch(plate)
            || regexMatoGrosso13.IsMatch(plate)
            || regexMatoGrosso14.IsMatch(plate)
            || regexMatoGrosso15.IsMatch(plate)
            || regexMatoGrosso16.IsMatch(plate)
            || regexMatoGrosso1Antiga.IsMatch(plate)
            || regexMatoGrosso2Antiga.IsMatch(plate)
            || regexMatoGrosso3Antiga.IsMatch(plate)
            || regexMatoGrosso4Antiga.IsMatch(plate)
            || regexMatoGrosso5Antiga.IsMatch(plate)
            || regexMatoGrosso6Antiga.IsMatch(plate)
            || regexMatoGrosso7Antiga.IsMatch(plate)
            || regexMatoGrosso8Antiga.IsMatch(plate)
            || regexMatoGrosso9Antiga.IsMatch(plate)
            || regexMatoGrosso10Antiga.IsMatch(plate)
            || regexMatoGrosso11Antiga.IsMatch(plate)
            || regexMatoGrosso12Antiga.IsMatch(plate)
            || regexMatoGrosso13Antiga.IsMatch(plate)
            || regexMatoGrosso14Antiga.IsMatch(plate)
            || regexMatoGrosso15Antiga.IsMatch(plate)
            || regexMatoGrosso16Antiga.IsMatch(plate)
        )
        {
            return "Mato Grosso";
        }
        else if (
            regexMatoGrossoSul1.IsMatch(plate)
            || regexMatoGrossoSul2.IsMatch(plate)
            || regexMatoGrossoSul3.IsMatch(plate)
            || regexMatoGrossoSul4.IsMatch(plate)
            || regexMatoGrossoSul5.IsMatch(plate)
            || regexMatoGrossoSul6.IsMatch(plate)
            || regexMatoGrossoSul7.IsMatch(plate)
            || regexMatoGrossoSul8.IsMatch(plate)
            || regexMatoGrossoSul9.IsMatch(plate)
            || regexMatoGrossoSul1Antiga.IsMatch(plate)
            || regexMatoGrossoSul2Antiga.IsMatch(plate)
            || regexMatoGrossoSul3Antiga.IsMatch(plate)
            || regexMatoGrossoSul4Antiga.IsMatch(plate)
            || regexMatoGrossoSul5Antiga.IsMatch(plate)
            || regexMatoGrossoSul6Antiga.IsMatch(plate)
            || regexMatoGrossoSul7Antiga.IsMatch(plate)
            || regexMatoGrossoSul8Antiga.IsMatch(plate)
            || regexMatoGrossoSul9Antiga.IsMatch(plate)
        )
        {
            return "Mato Grosso do Sul";
        }
        else if (
            regexTocantins1.IsMatch(plate)
            || regexTocantins1.IsMatch(plate)
            || regexTocantins2.IsMatch(plate)
            || regexTocantins3.IsMatch(plate)
            || regexTocantins4.IsMatch(plate)
            || regexTocantins5.IsMatch(plate)
            || regexTocantins6.IsMatch(plate)
            || regexTocantins7.IsMatch(plate)
            || regexTocantins8.IsMatch(plate)
            || regexTocantins1Antiga.IsMatch(plate)
            || regexTocantins2Antiga.IsMatch(plate)
            || regexTocantins3Antiga.IsMatch(plate)
            || regexTocantins4Antiga.IsMatch(plate)
            || regexTocantins5Antiga.IsMatch(plate)
            || regexTocantins6Antiga.IsMatch(plate)
            || regexTocantins7Antiga.IsMatch(plate)
            || regexTocantins8Antiga.IsMatch(plate)
        )
        {
            return "Tocantins";
        }
        return "Estado não cadastrado";
    }
}
