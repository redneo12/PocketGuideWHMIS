using MvvmHelpers;
using WHMIS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;


//https://github.com/jamesmontemagno/Xamarin.Forms-Monkeys

namespace WHMIS.Helpers
{
    public static class GlossaryHelper
    {
        public static ObservableCollection<Grouping<string, GlossaryItem>> GlossaryGrouped { get; set; }

        public static ObservableCollection<GlossaryItem> Glossary { get; set; }

        static GlossaryHelper()
        {
            Glossary = new ObservableCollection<GlossaryItem>();
            //Replace("\n" with "&#x0a;")


            //**WHMIS Dictionary**//
            #region WHMIS		
            Glossary.Add(new GlossaryItem
            {
                Element = "Act",
                Definition = "Means the Hazardous Products Act.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Accidental Release Measures",
                Definition = "Include:\n" +
                "\t(a) personal precautions, protective equipment and emergency procedures; and\n" +
                "\t(b) methods and materials for containment and cleaning up",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Acute Toxicant",
                Definition = "A mixture or substance that is liable to cause acute toxicity, or a mixture or substance that, upon contact with water, releases a gaseous substance that is liable to cause acute toxicity.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Acute Toxicity",
                Definition = "Refers to adverse effects occurring following:\n" +
                "\t(a) oral or dermal administration of a single dose of a mixture or substance, or multiple doses given within 24 hours; or\n" +
                "\t(b) an inhalation exposure to a mixture or substance of four hours or of a duration that is converted to four hours in accordance with subsection 8.1.1(4).",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Adverse Effects on Sexual Function and Fertility",
                Definition = "Any effect of a mixture or substance that is liable to interfere with sexual function or fertility, including:\n" +
                "\t(a) alterations to the female or male reproductive system;\n" +
                "\t(b) adverse effects on onset of puberty, gamete production or transport, the reproductive cycle, sexual behaviour, parturition or pregnancy outcomes;\n" +
                "\t(c) premature reproductive senescence; o\n" +
                "\t(d) any modifications to other functions that are dependent on the integrity of the reproductive system.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Adverse Effects on the Development of the Embryo, Fetus or Offspring",
                Definition = "Any adverse effects of a mixture or substance on the embryo, fetus or offspring, resulting from exposure of either parent to the mixture or substance prior to conception or exposure of the developing embryo or fetus to the mixture or substance during prenatal development, or of the offspring during postnatal development to the time of sexual maturation, that is manifested at any point in the development of the embryo or fetus, or that is manifested at any point in the lifespan of the offspring, and that includes the loss of the embryo or fetus, death of the developing offspring, structural abnormality, altered growth and functional deficiency. This definition excludes the induction of genetically based inheritable effects in the offspring.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Aerosol Dispenser",
                Definition = "A non-refillable receptacle made of metal, glass or plastic and containing a gas that is compressed, liquefied or dissolved under pressure, with or without a liquid, foam, mousse, paste, gel or powder, and fitted with a release device allowing the contents to be ejected in the form of solid or liquid particles in suspension in a gas, as a foam, mousse, paste, gel or powder or in a liquid or gaseous state.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Analyst",
                Definition = "An individual designated as an analyst under subsection 21(1).",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "As Packaged",
                Definition = "Means packaged in the form and condition described in test series B, D, G and H of Part II of the Manual of Tests and Criteria.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Aspiration Toxicant",
                Definition = "A mixture or substance that is liable to cause aspiration toxicity.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Aspiration Toxicity",
                Definition = "Includes severe acute effects, such as chemical pneumonia, varying degrees of pulmonary injury or death, following the entry of a liquid or solid directly through the oral or nasal cavity, or indirectly from vomiting, into the trachea and lower respiratory system.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "ATE",
                Definition = "Means an acute toxicity estimate, and includes the LD50 and the LC50, and the acute toxicity point estimate determined in accordance with the table to section 8.1.7.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Bulk Shipment",
                Definition = "A shipment of a hazardous product that is contained in any of the following, without intermediate containment or intermediate packaging:(a) a vessel that has a water capacity equal to or greater than 450 l;(b) a freight container, road vehicle, railway vehicle or portable tank;(c) the hold of a ship; or(d) a pipeline.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "CAS Registry Number",
                Definition = "The identification number assigned to a chemical by the Chemical Abstracts Service, a division of the American Chemical Society.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Chemical Name",
                Definition = "A scientific designation of a material or substance that is made in accordance with the rules of nomenclature of either the Chemical Abstracts Service, a division of the American Chemical Society, or the International Union of Pure and Applied Chemistry, or a scientific designation of a material or substance that is internationally recognized and that clearly identifies the material or substance.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Complex Mixture",
                Definition = "Means a mixture that has a commonly known generic name and that is:(a) naturally occurring;(b) a fraction of a naturally occurring mixture that results from a separation process; or(c) a modification of a naturally occurring mixture or a modification of a fraction of a naturally occurring mixture that results from a chemical modification process.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Container",
                Definition = "Includes a bag, barrel, bottle, box, can, cylinder, drum or similar package or receptacle but does not include a storage tank.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Document",
                Definition = "Anything on which information that is capable of being understood by an individual or being read by a computer or other device is recorded or marked.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Dust",
                Definition = "Solid particles that are suspended in a gas, usually air.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Effects On or Via Lactation",
                Definition = "Means: (a) any effect of a mixture or substance that interferes with lactation; or(b) the presence of the mixture or substance, or its metabolites, in the maternal milk in amounts for which there is evidence that supports the conclusion, based on established scientific principles, that the health of the breast-fed child or suckling animal is liable to be threatened.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Explosive Properties",
                Definition = "The properties of a self-reactive substance or mixture that, in laboratory testing according to test series A, C or E of Part II of the Manual of Tests and Criteria, make the substance or mixture liable to detonate, deflagrate rapidly or show a violent effect when heated under confinement.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Eye Irritation",
                Definition = "The production of changes in the eye that are fully reversible within an observation period of 21 days.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Flammable Gas",
                Definition = "A gas that has a flammable range when mixed with air (at 20 deg C and 101.3 kPa).",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Flammable Liquid",
                Definition = "A liquid that has a flash point of not more than 93°C.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Flammable Solid",
                Definition = "A readily combustible solid or a solid that is liable to cause or contribute to fire through friction.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Flash Point",
                Definition = "The lowest temperature, corrected to the standard pressure of 101.3 kPa, at which the application of an ignition source causes the vapours of a liquid to ignite.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Gas",
                Definition = "A mixture or substance that(a) at 50°C has an absolute vapour pressure of greater than 300 kPa; or(b) is completely gaseous at 20°C and at the standard pressure of 101.3 kPa.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Genotoxicity",
                Definition = "The alteration of the structure, information content or segregation of DNA by an agent or process, including those agents or processes that cause DNA damage by interfering with normal replication processes or that in a non-physiological manner temporarily alter its replication.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Germ Cell Mutagen",
                Definition = "A mixture or substance that is liable to lead to an increased occurrence of mutations in the germ cells of a population.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "GHS",
                Definition = "Globally Harmonized System - relating to the United Nations document entitled Globally Harmonized System of Classification and Labelling of Chemicals (GHS), Fifth Revised Edition.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Hazard Category",
                Definition = "The subdivision within a hazard class that tells you about how hazardous the product is (the severity of hazard). Category 1 is always the greatest level of hazard (it is the most hazardous within that class). If Category 1 is further divided, Category 1A within the same hazard class is a greater hazard than category 1B. Category 2 within the same hazard class is more hazardous than category 3, and so on.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Hazard Class",
                Definition = "A way of grouping products together that have similar hazards or properties.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Hazard Statement",
                Definition = "A phrase assigned to a category or subcategory of a hazard class or, in the case of column 5 of Parts 4 to 6 of Schedule 5, the required statement that describes the nature of the hazard presented by a hazardous product.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Hazardous Ingredient",
                Definition = "An ingredient in a mixture that, when evaluated as an individual substance, is classified in a category or subcategory of a health hazard class.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Hazardous Product",
                Definition = "Any product, mixture, material or substance that is classified in accordance with the regulations made under subsection 15(1) in a category or subcategory of a hazard class listed in Schedule 2.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "HPR",
                Definition = "Hazardous Products Regulations.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Import",
                Definition = "Means to import into Canada.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Initial Boiling Point",
                Definition = "The temperature of a liquid at which its vapour pressure is equal to the standard pressure of 101.3 kPa, i.e., the temperature at which the first gas bubble appears.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Initial Supplier Identifier",
                Definition = "The name, address and telephone number of:(a) the manufacturer; or(b) the importer of the hazardous product who operates in Canada.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Inspector",
                Definition = "An individual designated as an inspector under subsection 21(1).",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Label",
                Definition = "A group of written, printed or graphic information elements that relate to a hazardous product, which group is designed to be affixed to, printed on or attached to the hazardous product or the container in which the hazardous product is packaged.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "LC50",
                Definition = "The concentration of a mixture or substance in air that causes the death of 50.0% of a group of test animals.",
                
            });


            Glossary.Add(new GlossaryItem
            {
                Element = "LD50",
                Definition = "The single dose of a mixture or substance that, when administered by a particular exposure route in an animal study, is expected to cause the death of 50.0% of a given animal population.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Liquid",
                Definition = "A mixture or substance that:(a) at 50°C has a vapour pressure of 300 kPa or less;(b) is not completely gaseous at 20°C and at the standard pressure of 101.3 kPa; and(c) has a melting point or initial melting point of 20°C or less at the standard pressure of 101.3 kPa or, in the case of a mixture or substance for which neither can be determined, is shown: (i) to be a liquid as a result of the ASTM International method ASTM D4359-90, entitled Standard Test Method for Determining Whether a Material Is a Liquid or a Solid, as amended from time to time, or(ii) to not be pasty as a result of the test for determining fluidity (penetrometer test), referred to in section 4 of chapter 3 of Part 2, numbered 2.3.4, of Annex A of the European Agreement Concerning the International Carriage of Dangerous Goods by Road, as amended from time to time.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Manual of Tests and Criteria",
                Definition = "The United Nations document entitled Recommendations on the Transport of Dangerous Goods: Manual of Tests and Criteria, as amended from time to time.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Manufactured Article",
                Definition = "Any article that is formed to a specific shape or design during manufacture, the intended use of which when in that form is dependent in whole or in part on its shape or design, and that, when being installed, if the intended use of the article requires it to be installed, and under normal conditions of use, will not release or otherwise cause an individual to be exposed to a hazardous product.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Manufacturer",
                Definition = "A supplier who, in the course of business in Canada, manufactures, produces, processes, packages or labels a hazardous product and sells it.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Minister",
                Definition = "Means the Minister of Health.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Mist",
                Definition = "Liquid droplets that are suspended in the air.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Mixture",
                Definition = "A combination of, or a solution that is composed of, two or more ingredients that, when they are combined, do not react with each other, but excludes any such combination or solution that is a substance.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Mutagenic",
                Definition = "In relation to a mixture or substance, liable to lead to an increased occurrence of mutations in populations of cells or organisms.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Mutagenicity",
                Definition = "An increased occurrence of mutations in populations of cells or organisms.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Mutation",
                Definition = "A permanent change in the amount or structure of the genetic material in a cell and includes:(a) the heritable genetic changes that may be manifested at the phenotypic level; and(b) the underlying DNA modifications when known, including specific base pair changes and chromosomal translocations.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Narcotic Effects",
                Definition = "Means central nervous system depression that:(a) in humans, may present as drowsiness, narcosis, reduced alertness, loss of reflexes, lack of coordination, vertigo, severe headache or nausea and may lead to reduced judgment, dizziness, irritability, fatigue, impaired memory function, deficits in perception or coordination, prolonged reaction time or sleepiness; and(b) in animals, may be observed as lethargy, lack of coordination righting reflex, narcosis or ataxia.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "OECD",
                Definition = "Means the Organisation for Economic Co-operation and Development.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Organ",
                Definition = "Includes any biological system.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Organic Peroxides",
                Definition = "Hazardous products that are reactive and may cause a fire or explosion if heated.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Outer Container",
                Definition = "Oxidizing GasesOxidizing LiquidsOxidizing Solids Hazardous products that may cause or intensify a fire, or cause a fire or explosion. Oxidizing gases are liable to cause or contribute to the combustion of other material more than air does. Oxidizing liquids and Oxidizing solids are liable to cause or contribute to the combustion of other material.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Oxidizing Gases / Oxidizing Liquids / Oxidizing Solids",
                Definition = "Hazardous products that may cause or intensify a fire, or cause a fire or explosion. Oxidizing gases are liable to cause or contribute to the combustion of other material more than air does. Oxidizing liquids and Oxidizing solids are liable to cause or contribute to the combustion of other material.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Person",
                Definition = "An individual or an organization as defined in section 2 of the Criminal Code.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Personal Protective Equipment (PPE)",
                Definition = "The clothing or equipment that a worker handling a hazardous product wears to reduce or prevent exposure to the product. PPE may include coveralls, face shields, aprons, gloves or respirators.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Physical Hazards Not Otherwise Classified (PHNOC)",
                Definition = "Hazardous products that present a physical hazard that is different from any other physical hazard addressed in the HPR. These hazards must have the characteristic of occurring by chemical reaction and resulting in the serious injury or death of a person at the time the reaction occurs. If a product is classified in this hazard class, the hazard statement on the label and SDS will describe the nature of the hazard.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Pictogram",
                Definition = "A graphical composition that includes a symbol along with other graphical elements, such as a border or background colour.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Precautionary Statement",
                Definition = "A phrase that describes the recommended measures to take in order to minimize or prevent adverse effects resulting from exposure to a hazardous product or resulting from improper storage or handling of a hazardous product.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Product Identifier",
                Definition = "In respect of a hazardous product, the brand name, chemical name, common name, generic name or trade name.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Pyrophoric Gases / Pyrophoric Liquids / Pyrophoric Solids",
                Definition = "Hazardous products that can catch fire spontaneously if exposed to air. Pyrophoric liquids and pyrophoric solids are liable to ignite within five minutes after coming into contact with air. Pyrophoric gases are liable to ignite spontaneously in air at a temperature of 54 deg C or less.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Reactivity",
                Definition = "Describes the intrinsic ability of a product to undergo a hazardous chemical change (e.g., organic peroxide, oxidizer, self-reactive, pyrophoric, self-heating).",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Readily Combustible Solid",
                Definition = "A powdered, granular or pasty mixture or substance that can be easily ignited by brief contact with an ignition source and, when ignited, has a flame that spreads rapidly.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Reproductive Toxicity",
                Definition = "Refers to:(a) adverse effects on sexual function and fertility;(b) adverse effects on the development of the embryo, fetus or offspring; or(c) effects on or via lactation.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Respiratory Sensitization",
                Definition = "The production of hypersensitivity of the airways following inhalation.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Respiratory Sensitizer",
                Definition = "A mixture or substance that is liable to lead to hypersensitivity of the airways following inhalation.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Respiratory Tract Irritation",
                Definition = "Localized redness, edema, pruritis or irritant effects in the respiratory tract that impair its function, whether or not accompanied by cough, pain, choking, breathing difficulties or other respiratory symptoms.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Risk Group Classification",
                Definition = "In relation to the &quot;Biohazardous Infectious Materials&quot; health hazard class, classification in Risk Group 2, Risk Group 3 or Risk Group 4 as defined in subsection 3(1) of the Human Pathogens and Toxins Act.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Route of Entry",
                Definition = "Refers to the way in which a product can enter the body. Hazardous products can affect the body if inhaled, following skin contact (including absorption through the skin) or eye contact, and if ingested (swallowed).",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "SADT",
                Definition = "Self-Accelerating Decomposition Temperature, means the lowest temperature at which self-accelerating decomposition occurs.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Safety Data Sheet (SDS)",
                Definition = "A document that contains, under the headings that, by virtue of the regulations made under subsection 15(1), are required to appear in the document, information about a hazardous product, including information related to the hazards associated with any use, handling or storage of the hazardous product in a work place.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Scientifically Validated Method",
                Definition = "In relation to a hazard, a method that specifies standards for the evaluation of that hazard and whose results are accurate and reproducible, in accordance with established scientific principles.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Self-Reactive",
                Definition = "In relation to a thermally unstable liquid or solid product, mixture or substance, liable to undergo a strongly exothermic decomposition, having a heat of decomposition equal to or greater than 300 J/g, even without participation of oxygen.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Serious Eye Damage",
                Definition = "The production of tissue damage in the eye or serious physical decay of vision:(a) for which data demonstrate that it is irreversible; or(b) that is not fully reversible within an observation period of 21 days.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Sell",
                Definition = "Includes:\n" +
                "\t(a) offer for sale or distribution, expose for sale or distribution, have in possession for sale or distribution or distribute - whether for consideration or not - to one or more recipients, and\n" +
                "\t(b) make any transfer of possession that creates a bailment or, in Quebec, make any transfer of possession of a movable, for a specific purpose, without transferring ownership, and with the obligation to deliver the movable to a specified person or to return it, such as a transfer by means of a deposit, a lease, a pledge, a loan for use or a contract of carriage.\n",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Signal Word",
                Definition = "Means, in respect of a hazardous product, the word &quot;Danger&quot; or &quot;Warning&quot; that is used to alert the reader to a potential hazard and to indicate its severity.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Significant New Data",
                Definition = "Means new data regarding the hazard presented by a hazardous product that change its classification in a category or subcategory of a hazard class, or result in its classification in another hazard class, or change the ways to protect against the hazard presented by the hazardous product.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Skin Corrosion",
                Definition = "The production of irreversible damage to the skin, namely, visible necrosis through the epidermis and into the dermis, and includes ulcers, bleeding, bloody scabs and, within a 14-day observation period, discoloration due to blanching of the skin, complete areas of alopecia, and scars.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Skin Irritation",
                Definition = "The production of reversible damage to the skin.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Skin Sensitization",
                Definition = "The production of an allergic response following skin contact.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Skin Sensitizer",
                Definition = "A mixture or substance that is liable to lead to an allergic response following skin contact.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Skin Corrosive",
                Definition = "In relation to a mixture or substance, liable to cause skin corrosion.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Skin Irritant",
                Definition = "In relation to a mixture or substance, liable to cause skin irritation.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Solid",
                Definition = "Means a mixture or substance that is not a liquid or gas.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Specific Target Organ Toxicity Arising From a Single Exposure",
                Definition = "Specific, non-lethal toxic effects on target organs that arise from a single exposure to a mixture or substance, including all health effects liable to impair function of the body or any of its parts, whether reversible or irreversible, immediate or delayed, but excludes effects resulting from health hazards addressed by Subparts 1 to 7 and 10 of this Part.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Specific Target Organ Toxicity Arising From Repeated Exposure",
                Definition = "Specific toxic effects on target organs that arise from repeated exposure to a mixture or substance, including all health effects liable to impair function of the body or any of its parts, whether reversible or irreversible, immediate or delayed, but excludes effects resulting from health hazards addressed by Subparts 1 to 7 and 10 of Part 8.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Substance",
                Definition = "Any chemical element or chemical compound — that is in its natural state or that is obtained by a production process — whether alone or together with:(a) any additive that is necessary to preserve the stability of the chemical element or chemical compound,(b) any solvent that is necessary to preserve the stability or composition of the chemical element or chemical compound, or(c) any impurity that is derived from the production process.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Supplier",
                Definition = "A person who, in the course of business, sells or imports a hazardous product.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Toxic to Reproduction",
                Definition = "Means, in relation to a mixture or substance, liable to lead to reproductive toxicity.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Trade Secret",
                Definition = "When a product is considered hazardous but certain information is considered confidential or a trade secret, then a claim may be filed with Health Canada to protect this Confidential Business Information (CBI) under the Hazardous Materials Information Review Act (HMIRA).",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "UN Number",
                Definition = "The four-digit identification number issued in accordance with the United Nations Model Regulations.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "United Nations Model Regulations",
                Definition = "Means the United Nations document entitled Recommendations on the Transport of Dangerous Goods: Model Regulations, as amended from time to time.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Vapour",
                Definition = "The gaseous form of a mixture or substance released from its liquid or solid state.",
                
            });



            Glossary.Add(new GlossaryItem
            {
                Element = "Workplace",
                Definition = "A place where a person works for remuneration.",
                
            });

            #endregion




        }
    }
}
