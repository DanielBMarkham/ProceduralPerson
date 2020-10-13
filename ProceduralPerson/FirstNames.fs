﻿module FirstNames
let femaleFirstNamesAndFrequenciesArray =
  [|
    ("MARY","2.629")
    ;("PATRICIA","1.073")
    ;("LINDA","1.035")
    ;("BARBARA","0.98")
    ;("ELIZABETH","0.937")
    ;("JENNIFER","0.932")
    ;("MARIA","0.828")
    ;("SUSAN","0.794")
    ;("MARGARET","0.768")
    ;("DOROTHY","0.727")
    ;("LISA","0.704")
    ;("NANCY","0.669")
    ;("KAREN","0.667")
    ;("BETTY","0.666")
    ;("HELEN","0.663")
    ;("SANDRA","0.629")
    ;("DONNA","0.583")
    ;("CAROL","0.565")
    ;("RUTH","0.562")
    ;("SHARON","0.522")
    ;("MICHELLE","0.519")
    ;("LAURA","0.51")
    ;("SARAH","0.508")
    ;("KIMBERLY","0.504")
    ;("DEBORAH","0.494")
    ;("JESSICA","0.49")
    ;("SHIRLEY","0.482")
    ;("CYNTHIA","0.469")
    ;("ANGELA","0.468")
    ;("MELISSA","0.462")
    ;("BRENDA","0.455")
    ;("AMY","0.451")
    ;("ANNA","0.44")
    ;("REBECCA","0.43")
    ;("VIRGINIA","0.43")
    ;("KATHLEEN","0.424")
    ;("PAMELA","0.416")
    ;("MARTHA","0.412")
    ;("DEBRA","0.408")
    ;("AMANDA","0.404")
    ;("STEPHANIE","0.4")
    ;("CAROLYN","0.385")
    ;("CHRISTINE","0.382")
    ;("MARIE","0.379")
    ;("JANET","0.379")
    ;("CATHERINE","0.373")
    ;("FRANCES","0.37")
    ;("ANN","0.364")
    ;("JOYCE","0.364")
    ;("DIANE","0.359")
    ;("ALICE","0.357")
    ;("JULIE","0.348")
    ;("HEATHER","0.337")
    ;("TERESA","0.336")
    ;("DORIS","0.335")
    ;("GLORIA","0.335")
    ;("EVELYN","0.322")
    ;("JEAN","0.315")
    ;("CHERYL","0.315")
    ;("MILDRED","0.313")
    ;("KATHERINE","0.313")
    ;("JOAN","0.306")
    ;("ASHLEY","0.303")
    ;("JUDITH","0.297")
    ;("ROSE","0.296")
    ;("JANICE","0.285")
    ;("KELLY","0.283")
    ;("NICOLE","0.281")
    ;("JUDY","0.276")
    ;("CHRISTINA","0.275")
    ;("KATHY","0.272")
    ;("THERESA","0.271")
    ;("BEVERLY","0.267")
    ;("DENISE","0.264")
    ;("TAMMY","0.259")
    ;("IRENE","0.252")
    ;("JANE","0.25")
    ;("LORI","0.248")
    ;("RACHEL","0.242")
    ;("MARILYN","0.241")
    ;("ANDREA","0.236")
    ;("KATHRYN","0.234")
    ;("LOUISE","0.229")
    ;("SARA","0.229")
    ;("ANNE","0.228")
    ;("JACQUELINE","0.228")
    ;("WANDA","0.226")
    ;("BONNIE","0.223")
    ;("JULIA","0.223")
    ;("RUBY","0.221")
    ;("LOIS","0.22")
    ;("TINA","0.22")
    ;("PHYLLIS","0.219")
    ;("NORMA","0.218")
    ;("PAULA","0.217")
    ;("DIANA","0.216")
    ;("ANNIE","0.216")
    ;("LILLIAN","0.211")
    ;("EMILY","0.208")
    ;("ROBIN","0.208")
    ;("PEGGY","0.208")
    ;("CRYSTAL","0.207")
    ;("GLADYS","0.205")
    ;("RITA","0.204")
    ;("DAWN","0.202")
    ;("CONNIE","0.2")
    ;("FLORENCE","0.2")
    ;("TRACY","0.197")
    ;("EDNA","0.197")
    ;("TIFFANY","0.195")
    ;("CARMEN","0.195")
    ;("ROSA","0.194")
    ;("CINDY","0.192")
    ;("GRACE","0.189")
    ;("WENDY","0.185")
    ;("VICTORIA","0.18")
    ;("EDITH","0.179")
    ;("KIM","0.178")
    ;("SHERRY","0.178")
    ;("SYLVIA","0.177")
    ;("JOSEPHINE","0.177")
    ;("THELMA","0.175")
    ;("SHANNON","0.175")
    ;("SHEILA","0.175")
    ;("ETHEL","0.174")
    ;("ELLEN","0.173")
    ;("ELAINE","0.173")
    ;("MARJORIE","0.173")
    ;("CARRIE","0.171")
    ;("CHARLOTTE","0.169")
    ;("MONICA","0.166")
    ;("ESTHER","0.166")
    ;("PAULINE","0.165")
    ;("EMMA","0.165")
    ;("JUANITA","0.164")
    ;("ANITA","0.162")
    ;("RHONDA","0.162")
    ;("HAZEL","0.161")
    ;("AMBER","0.16")
    ;("EVA","0.159")
    ;("DEBBIE","0.157")
    ;("APRIL","0.154")
    ;("LESLIE","0.154")
    ;("CLARA","0.153")
    ;("LUCILLE","0.153")
    ;("JAMIE","0.153")
    ;("JOANNE","0.15")
    ;("ELEANOR","0.15")
    ;("VALERIE","0.149")
    ;("DANIELLE","0.149")
    ;("MEGAN","0.147")
    ;("ALICIA","0.146")
    ;("SUZANNE","0.145")
    ;("MICHELE","0.145")
    ;("GAIL","0.145")
    ;("BERTHA","0.143")
    ;("DARLENE","0.142")
    ;("VERONICA","0.142")
    ;("JILL","0.142")
    ;("ERIN","0.141")
    ;("GERALDINE","0.141")
    ;("LAUREN","0.137")
    ;("CATHY","0.137")
    ;("JOANN","0.136")
    ;("LORRAINE","0.135")
    ;("LYNN","0.135")
    ;("SALLY","0.135")
    ;("REGINA","0.133")
    ;("ERICA","0.13")
    ;("BEATRICE","0.13")
    ;("DOLORES","0.129")
    ;("BERNICE","0.128")
    ;("AUDREY","0.127")
    ;("YVONNE","0.126")
    ;("ANNETTE","0.125")
    ;("JUNE","0.125")
    ;("SAMANTHA","0.124")
    ;("MARION","0.122")
    ;("DANA","0.122")
    ;("STACY","0.121")
    ;("ANA","0.12")
    ;("RENEE","0.12")
    ;("IDA","0.118")
    ;("VIVIAN","0.118")
    ;("ROBERTA","0.117")
    ;("HOLLY","0.117")
    ;("BRITTANY","0.117")
    ;("MELANIE","0.116")
    ;("LORETTA","0.115")
    ;("YOLANDA","0.115")
    ;("JEANETTE","0.115")
    ;("LAURIE","0.114")
    ;("KATIE","0.113")
    ;("KRISTEN","0.111")
    ;("VANESSA","0.111")
    ;("ALMA","0.111")
    ;("SUE","0.111")
    ;("ELSIE","0.11")
    ;("BETH","0.11")
    ;("JEANNE","0.109")
    ;("VICKI","0.109")
    ;("CARLA","0.107")
    ;("TARA","0.107")
    ;("ROSEMARY","0.107")
    ;("EILEEN","0.105")
    ;("TERRI","0.105")
    ;("GERTRUDE","0.103")
    ;("LUCY","0.103")
    ;("TONYA","0.102")
    ;("ELLA","0.101")
    ;("STACEY","0.101")
    ;("WILMA","0.099")
    ;("GINA","0.099")
    ;("KRISTIN","0.099")
    ;("JESSIE","0.098")
    ;("NATALIE","0.098")
    ;("AGNES","0.098")
    ;("VERA","0.098")
    ;("WILLIE","0.097")
    ;("CHARLENE","0.097")
    ;("BESSIE","0.096")
    ;("DELORES","0.095")
    ;("MELINDA","0.094")
    ;("PEARL","0.094")
    ;("ARLENE","0.094")
    ;("MAUREEN","0.092")
    ;("COLLEEN","0.092")
    ;("ALLISON","0.092")
    ;("TAMARA","0.092")
    ;("JOY","0.091")
    ;("GEORGIA","0.091")
    ;("CONSTANCE","0.091")
    ;("LILLIE","0.09")
    ;("CLAUDIA","0.09")
    ;("JACKIE","0.09")
    ;("MARCIA","0.09")
    ;("TANYA","0.089")
    ;("NELLIE","0.089")
    ;("MINNIE","0.089")
    ;("MARLENE","0.088")
    ;("HEIDI","0.088")
    ;("GLENDA","0.088")
    ;("LYDIA","0.086")
    ;("VIOLA","0.086")
    ;("COURTNEY","0.086")
    ;("MARIAN","0.086")
    ;("STELLA","0.085")
    ;("CAROLINE","0.085")
    ;("DORA","0.084")
    ;("JO","0.083")
    ;("VICKIE","0.082")
    ;("MATTIE","0.081")
    ;("TERRY","0.08")
    ;("MAXINE","0.079")
    ;("IRMA","0.079")
    ;("MABEL","0.078")
    ;("MARSHA","0.078")
    ;("MYRTLE","0.078")
    ;("LENA","0.077")
    ;("CHRISTY","0.077")
    ;("DEANNA","0.076")
    ;("PATSY","0.076")
    ;("HILDA","0.075")
    ;("GWENDOLYN","0.074")
    ;("JENNIE","0.073")
    ;("NORA","0.073")
    ;("MARGIE","0.072")
    ;("NINA","0.072")
    ;("CASSANDRA","0.072")
    ;("LEAH","0.072")
    ;("PENNY","0.071")
    ;("KAY","0.071")
    ;("PRISCILLA","0.071")
    ;("NAOMI","0.071")
    ;("CAROLE","0.071")
    ;("BRANDY","0.07")
    ;("OLGA","0.07")
    ;("BILLIE","0.069")
    ;("DIANNE","0.069")
    ;("TRACEY","0.069")
    ;("LEONA","0.069")
    ;("JENNY","0.068")
    ;("FELICIA","0.068")
    ;("SONIA","0.068")
    ;("MIRIAM","0.066")
    ;("VELMA","0.066")
    ;("BECKY","0.066")
    ;("BOBBIE","0.065")
    ;("VIOLET","0.065")
    ;("KRISTINA","0.065")
    ;("TONI","0.064")
    ;("MISTY","0.063")
    ;("MAE","0.063")
    ;("SHELLY","0.062")
    ;("DAISY","0.062")
    ;("RAMONA","0.062")
    ;("SHERRI","0.062")
    ;("ERIKA","0.061")
    ;("KATRINA","0.061")
    ;("CLAIRE","0.061")
    ;("LINDSEY","0.06")
    ;("LINDSAY","0.06")
    ;("GENEVA","0.059")
    ;("GUADALUPE","0.059")
    ;("BELINDA","0.059")
    ;("MARGARITA","0.059")
    ;("SHERYL","0.059")
    ;("CORA","0.058")
    ;("FAYE","0.058")
    ;("ADA","0.057")
    ;("NATASHA","0.057")
    ;("SABRINA","0.057")
    ;("ISABEL","0.057")
    ;("MARGUERITE","0.056")
    ;("HATTIE","0.056")
    ;("HARRIET","0.056")
    ;("MOLLY","0.055")
    ;("CECILIA","0.055")
    ;("KRISTI","0.055")
    ;("BRANDI","0.055")
    ;("BLANCHE","0.055")
    ;("SANDY","0.055")
    ;("ROSIE","0.055")
    ;("JOANNA","0.055")
    ;("IRIS","0.055")
    ;("EUNICE","0.054")
    ;("ANGIE","0.054")
    ;("INEZ","0.053")
    ;("LYNDA","0.053")
    ;("MADELINE","0.052")
    ;("AMELIA","0.052")
    ;("ALBERTA","0.052")
    ;("GENEVIEVE","0.051")
    ;("MONIQUE","0.051")
    ;("JODI","0.051")
    ;("JANIE","0.051")
    ;("MAGGIE","0.051")
    ;("KAYLA","0.051")
    ;("SONYA","0.051")
    ;("JAN","0.051")
    ;("LEE","0.051")
    ;("KRISTINE","0.051")
    ;("CANDACE","0.051")
    ;("FANNIE","0.05")
    ;("MARYANN","0.05")
    ;("OPAL","0.05")
    ;("ALISON","0.05")
    ;("YVETTE","0.05")
    ;("MELODY","0.05")
    ;("LUZ","0.049")
    ;("SUSIE","0.049")
    ;("OLIVIA","0.049")
    ;("FLORA","0.049")
    ;("SHELLEY","0.049")
    ;("KRISTY","0.048")
    ;("MAMIE","0.048")
    ;("LULA","0.048")
    ;("LOLA","0.048")
    ;("VERNA","0.048")
    ;("BEULAH","0.048")
    ;("ANTOINETTE","0.048")
    ;("CANDICE","0.046")
    ;("JUANA","0.046")
    ;("JEANNETTE","0.046")
    ;("PAM","0.046")
    ;("KELLI","0.046")
    ;("HANNAH","0.045")
    ;("WHITNEY","0.045")
    ;("BRIDGET","0.045")
    ;("KARLA","0.044")
    ;("CELIA","0.044")
    ;("LATOYA","0.043")
    ;("PATTY","0.043")
    ;("SHELIA","0.043")
    ;("GAYLE","0.043")
    ;("DELLA","0.043")
    ;("VICKY","0.043")
    ;("LYNNE","0.043")
    ;("SHERI","0.042")
    ;("MARIANNE","0.042")
    ;("KARA","0.041")
    ;("JACQUELYN","0.041")
    ;("ERMA","0.041")
    ;("BLANCA","0.041")
    ;("MYRA","0.04")
    ;("LETICIA","0.04")
    ;("PAT","0.04")
    ;("KRISTA","0.04")
    ;("ROXANNE","0.04")
    ;("ANGELICA","0.039")
    ;("JOHNNIE","0.039")
    ;("ROBYN","0.039")
    ;("FRANCIS","0.039")
    ;("ADRIENNE","0.039")
    ;("ROSALIE","0.039")
    ;("ALEXANDRA","0.039")
    ;("BROOKE","0.039")
    ;("BETHANY","0.039")
    ;("SADIE","0.039")
    ;("BERNADETTE","0.039")
    ;("TRACI","0.038")
    ;("JODY","0.038")
    ;("KENDRA","0.038")
    ;("JASMINE","0.038")
    ;("NICHOLE","0.038")
    ;("RACHAEL","0.038")
    ;("CHELSEA","0.038")
    ;("MABLE","0.038")
    ;("ERNESTINE","0.038")
    ;("MURIEL","0.038")
    ;("MARCELLA","0.037")
    ;("ELENA","0.037")
    ;("KRYSTAL","0.037")
    ;("ANGELINA","0.037")
    ;("NADINE","0.036")
    ;("KARI","0.036")
    ;("ESTELLE","0.036")
    ;("DIANNA","0.036")
    ;("PAULETTE","0.036")
    ;("LORA","0.036")
    ;("MONA","0.035")
    ;("DOREEN","0.035")
    ;("ROSEMARIE","0.035")
    ;("ANGEL","0.035")
    ;("DESIREE","0.035")
    ;("ANTONIA","0.035")
    ;("HOPE","0.034")
    ;("GINGER","0.034")
    ;("JANIS","0.034")
    ;("BETSY","0.034")
    ;("CHRISTIE","0.034")
    ;("FREDA","0.034")
    ;("MERCEDES","0.033")
    ;("MEREDITH","0.033")
    ;("LYNETTE","0.033")
    ;("TERI","0.033")
    ;("CRISTINA","0.033")
    ;("EULA","0.033")
    ;("LEIGH","0.032")
    ;("MEGHAN","0.032")
    ;("SOPHIA","0.032")
    ;("ELOISE","0.032")
    ;("ROCHELLE","0.032")
    ;("GRETCHEN","0.032")
    ;("CECELIA","0.032")
    ;("RAQUEL","0.031")
    ;("HENRIETTA","0.031")
    ;("ALYSSA","0.031")
    ;("JANA","0.031")
    ;("KELLEY","0.031")
    ;("GWEN","0.031")
    ;("KERRY","0.031")
    ;("JENNA","0.03")
    ;("TRICIA","0.03")
    ;("LAVERNE","0.03")
    ;("OLIVE","0.03")
    ;("ALEXIS","0.03")
    ;("TASHA","0.03")
    ;("SILVIA","0.029")
    ;("ELVIRA","0.029")
    ;("CASEY","0.029")
    ;("DELIA","0.029")
    ;("SOPHIE","0.029")
    ;("KATE","0.029")
    ;("PATTI","0.029")
    ;("LORENA","0.029")
    ;("KELLIE","0.029")
    ;("SONJA","0.029")
    ;("LILA","0.029")
    ;("LANA","0.029")
    ;("DARLA","0.029")
    ;("MAY","0.029")
    ;("MINDY","0.029")
    ;("ESSIE","0.029")
    ;("MANDY","0.029")
    ;("LORENE","0.028")
    ;("ELSA","0.028")
    ;("JOSEFINA","0.028")
    ;("JEANNIE","0.028")
    ;("MIRANDA","0.028")
    ;("DIXIE","0.028")
    ;("LUCIA","0.028")
    ;("MARTA","0.028")
    ;("FAITH","0.028")
    ;("LELA","0.028")
    ;("JOHANNA","0.028")
    ;("SHARI","0.028")
    ;("CAMILLE","0.028")
    ;("TAMI","0.027")
    ;("SHAWNA","0.027")
    ;("ELISA","0.027")
    ;("EBONY","0.027")
    ;("MELBA","0.027")
    ;("ORA","0.027")
    ;("NETTIE","0.027")
    ;("TABITHA","0.027")
    ;("OLLIE","0.027")
    ;("JAIME","0.027")
    ;("WINIFRED","0.027")
    ;("KRISTIE","0.027")
    ;("MARINA","0.027")
    ;("ALISHA","0.027")
    ;("AIMEE","0.027")
    ;("RENA","0.027")
    ;("MYRNA","0.026")
    ;("MARLA","0.026")
    ;("TAMMIE","0.026")
    ;("LATASHA","0.026")
    ;("BONITA","0.026")
    ;("PATRICE","0.026")
    ;("RONDA","0.026")
    ;("SHERRIE","0.026")
    ;("ADDIE","0.026")
    ;("FRANCINE","0.025")
    ;("DELORIS","0.025")
    ;("STACIE","0.025")
    ;("ADRIANA","0.025")
    ;("CHERI","0.025")
    ;("SHELBY","0.025")
    ;("ABIGAIL","0.025")
    ;("CELESTE","0.025")
    ;("JEWEL","0.025")
    ;("CARA","0.025")
    ;("ADELE","0.025")
    ;("REBEKAH","0.025")
    ;("LUCINDA","0.025")
    ;("DORTHY","0.025")
    ;("CHRIS","0.024")
    ;("EFFIE","0.024")
    ;("TRINA","0.024")
    ;("REBA","0.024")
    ;("SHAWN","0.024")
    ;("SALLIE","0.024")
    ;("AURORA","0.024")
    ;("LENORA","0.024")
    ;("ETTA","0.024")
    ;("LOTTIE","0.024")
    ;("KERRI","0.024")
    ;("TRISHA","0.024")
    ;("NIKKI","0.024")
    ;("ESTELLA","0.024")
    ;("FRANCISCA","0.024")
    ;("JOSIE","0.024")
    ;("TRACIE","0.024")
    ;("MARISSA","0.024")
    ;("KARIN","0.024")
    ;("BRITTNEY","0.024")
    ;("JANELLE","0.024")
    ;("LOURDES","0.024")
    ;("LAUREL","0.024")
    ;("HELENE","0.024")
    ;("FERN","0.024")
    ;("ELVA","0.024")
    ;("CORINNE","0.024")
    ;("KELSEY","0.024")
    ;("INA","0.023")
    ;("BETTIE","0.023")
    ;("ELISABETH","0.023")
    ;("AIDA","0.023")
    ;("CAITLIN","0.023")
    ;("INGRID","0.023")
    ;("IVA","0.023")
    ;("EUGENIA","0.023")
    ;("CHRISTA","0.023")
    ;("GOLDIE","0.023")
    ;("CASSIE","0.023")
    ;("MAUDE","0.023")
    ;("JENIFER","0.023")
    ;("THERESE","0.022")
    ;("FRANKIE","0.022")
    ;("DENA","0.022")
    ;("LORNA","0.022")
    ;("JANETTE","0.022")
    ;("LATONYA","0.022")
    ;("CANDY","0.022")
    ;("MORGAN","0.022")
    ;("CONSUELO","0.022")
    ;("TAMIKA","0.022")
    ;("ROSETTA","0.022")
    ;("DEBORA","0.022")
    ;("CHERIE","0.022")
    ;("POLLY","0.022")
    ;("DINA","0.022")
    ;("JEWELL","0.021")
    ;("FAY","0.021")
    ;("JILLIAN","0.021")
    ;("DOROTHEA","0.021")
    ;("NELL","0.021")
    ;("TRUDY","0.021")
    ;("ESPERANZA","0.021")
    ;("PATRICA","0.021")
    ;("KIMBERLEY","0.021")
    ;("SHANNA","0.021")
    ;("HELENA","0.021")
    ;("CAROLINA","0.021")
    ;("CLEO","0.021")
    ;("STEFANIE","0.021")
    ;("ROSARIO","0.02")
    ;("OLA","0.02")
    ;("JANINE","0.02")
    ;("MOLLIE","0.02")
    ;("LUPE","0.02")
    ;("ALISA","0.02")
    ;("LOU","0.02")
    ;("MARIBEL","0.02")
    ;("SUSANNE","0.02")
    ;("BETTE","0.019")
    ;("SUSANA","0.019")
    ;("ELISE","0.019")
    ;("CECILE","0.019")
    ;("ISABELLE","0.019")
    ;("LESLEY","0.019")
    ;("JOCELYN","0.019")
    ;("PAIGE","0.019")
    ;("JONI","0.019")
    ;("RACHELLE","0.019")
    ;("LEOLA","0.019")
    ;("DAPHNE","0.019")
    ;("ALTA","0.019")
    ;("ESTER","0.019")
    ;("PETRA","0.019")
    ;("GRACIELA","0.019")
    ;("IMOGENE","0.019")
    ;("JOLENE","0.019")
    ;("KEISHA","0.019")
    ;("LACEY","0.018")
    ;("GLENNA","0.018")
    ;("GABRIELA","0.018")
    ;("KERI","0.018")
    ;("URSULA","0.018")
    ;("LIZZIE","0.018")
    ;("KIRSTEN","0.018")
    ;("SHANA","0.018")
    ;("ADELINE","0.018")
    ;("MAYRA","0.018")
    ;("JAYNE","0.018")
    ;("JACLYN","0.018")
    ;("GRACIE","0.018")
    ;("SONDRA","0.018")
    ;("CARMELA","0.018")
    ;("MARISA","0.018")
    ;("ROSALIND","0.018")
    ;("CHARITY","0.018")
    ;("TONIA","0.018")
    ;("BEATRIZ","0.018")
    ;("MARISOL","0.018")
    ;("CLARICE","0.018")
    ;("JEANINE","0.017")
    ;("SHEENA","0.017")
    ;("ANGELINE","0.017")
    ;("FRIEDA","0.017")
    ;("LILY","0.017")
    ;("ROBBIE","0.017")
    ;("SHAUNA","0.017")
    ;("MILLIE","0.017")
    ;("CLAUDETTE","0.017")
    ;("CATHLEEN","0.017")
    ;("ANGELIA","0.017")
    ;("GABRIELLE","0.017")
    ;("AUTUMN","0.017")
    ;("KATHARINE","0.017")
    ;("SUMMER","0.017")
    ;("JODIE","0.017")
    ;("STACI","0.017")
    ;("LEA","0.017")
    ;("CHRISTI","0.017")
    ;("JIMMIE","0.017")
    ;("JUSTINE","0.017")
    ;("ELMA","0.017")
    ;("LUELLA","0.017")
    ;("MARGRET","0.017")
    ;("DOMINIQUE","0.016")
    ;("SOCORRO","0.016")
    ;("RENE","0.016")
    ;("MARTINA","0.016")
    ;("MARGO","0.016")
    ;("MAVIS","0.016")
    ;("CALLIE","0.016")
    ;("BOBBI","0.016")
    ;("MARITZA","0.016")
    ;("LUCILE","0.016")
    ;("LEANNE","0.016")
    ;("JEANNINE","0.016")
    ;("DEANA","0.016")
    ;("AILEEN","0.016")
    ;("LORIE","0.016")
    ;("LADONNA","0.016")
    ;("WILLA","0.016")
    ;("MANUELA","0.016")
    ;("GALE","0.016")
    ;("SELMA","0.016")
    ;("DOLLY","0.016")
    ;("SYBIL","0.016")
    ;("ABBY","0.016")
    ;("LARA","0.016")
    ;("DALE","0.016")
    ;("IVY","0.016")
    ;("DEE","0.016")
    ;("WINNIE","0.016")
    ;("MARCY","0.016")
    ;("LUISA","0.016")
    ;("JERI","0.015")
    ;("MAGDALENA","0.015")
    ;("OFELIA","0.015")
    ;("MEAGAN","0.015")
    ;("AUDRA","0.015")
    ;("MATILDA","0.015")
    ;("LEILA","0.015")
    ;("CORNELIA","0.015")
    ;("BIANCA","0.015")
    ;("SIMONE","0.015")
    ;("BETTYE","0.015")
    ;("RANDI","0.015")
    ;("VIRGIE","0.015")
    ;("LATISHA","0.015")
    ;("BARBRA","0.015")
    ;("GEORGINA","0.015")
    ;("ELIZA","0.015")
    ;("LEANN","0.015")
    ;("BRIDGETTE","0.015")
    ;("RHODA","0.014")
    ;("HALEY","0.014")
    ;("ADELA","0.014")
    ;("NOLA","0.014")
    ;("BERNADINE","0.014")
    ;("FLOSSIE","0.014")
    ;("ILA","0.014")
    ;("GRETA","0.014")
    ;("RUTHIE","0.014")
    ;("NELDA","0.014")
    ;("MINERVA","0.014")
    ;("LILLY","0.014")
    ;("TERRIE","0.014")
    ;("LETHA","0.014")
    ;("HILARY","0.014")
    ;("ESTELA","0.014")
    ;("VALARIE","0.014")
    ;("BRIANNA","0.014")
    ;("ROSALYN","0.014")
    ;("EARLINE","0.014")
    ;("CATALINA","0.014")
    ;("AVA","0.014")
    ;("MIA","0.014")
    ;("CLARISSA","0.014")
    ;("LIDIA","0.014")
    ;("CORRINE","0.014")
    ;("ALEXANDRIA","0.014")
    ;("CONCEPCION","0.014")
    ;("TIA","0.014")
    ;("SHARRON","0.014")
    ;("RAE","0.014")
    ;("DONA","0.014")
    ;("ERICKA","0.014")
    ;("JAMI","0.014")
    ;("ELNORA","0.014")
    ;("CHANDRA","0.014")
    ;("LENORE","0.014")
    ;("NEVA","0.013")
    ;("MARYLOU","0.013")
    ;("MELISA","0.013")
    ;("TABATHA","0.013")
    ;("SERENA","0.013")
    ;("AVIS","0.013")
    ;("ALLIE","0.013")
    ;("SOFIA","0.013")
    ;("JEANIE","0.013")
    ;("ODESSA","0.013")
    ;("NANNIE","0.013")
    ;("HARRIETT","0.013")
    ;("LORAINE","0.013")
    ;("PENELOPE","0.013")
    ;("MILAGROS","0.013")
    ;("EMILIA","0.013")
    ;("BENITA","0.013")
    ;("ALLYSON","0.013")
    ;("ASHLEE","0.013")
    ;("TANIA","0.013")
    ;("TOMMIE","0.013")
    ;("ESMERALDA","0.013")
    ;("KARINA","0.013")
    ;("EVE","0.013")
    ;("PEARLIE","0.013")
    ;("ZELMA","0.013")
    ;("MALINDA","0.013")
    ;("NOREEN","0.013")
    ;("TAMEKA","0.013")
    ;("SAUNDRA","0.013")
    ;("HILLARY","0.013")
    ;("AMIE","0.013")
    ;("ALTHEA","0.012")
    ;("ROSALINDA","0.012")
    ;("JORDAN","0.012")
    ;("LILIA","0.012")
    ;("ALANA","0.012")
    ;("GAY","0.012")
    ;("CLARE","0.012")
    ;("ALEJANDRA","0.012")
    ;("ELINOR","0.012")
    ;("MICHAEL","0.012")
    ;("LORRIE","0.012")
    ;("JERRI","0.012")
    ;("DARCY","0.012")
    ;("EARNESTINE","0.012")
    ;("CARMELLA","0.012")
    ;("TAYLOR","0.012")
    ;("NOEMI","0.012")
    ;("MARCIE","0.012")
    ;("LIZA","0.012")
    ;("ANNABELLE","0.012")
    ;("LOUISA","0.012")
    ;("EARLENE","0.012")
    ;("MALLORY","0.012")
    ;("CARLENE","0.012")
    ;("NITA","0.012")
    ;("SELENA","0.012")
    ;("TANISHA","0.012")
    ;("KATY","0.012")
    ;("JULIANNE","0.012")
    ;("JOHN","0.012")
    ;("LAKISHA","0.011")
    ;("EDWINA","0.011")
    ;("MARICELA","0.011")
    ;("MARGERY","0.011")
    ;("KENYA","0.011")
    ;("DOLLIE","0.011")
    ;("ROXIE","0.011")
    ;("ROSLYN","0.011")
    ;("KATHRINE","0.011")
    ;("NANETTE","0.011")
    ;("CHARMAINE","0.011")
    ;("LAVONNE","0.011")
    ;("ILENE","0.011")
    ;("KRIS","0.011")
    ;("TAMMI","0.011")
    ;("SUZETTE","0.011")
    ;("CORINE","0.011")
    ;("KAYE","0.011")
    ;("JERRY","0.011")
    ;("MERLE","0.011")
    ;("CHRYSTAL","0.011")
    ;("LINA","0.011")
    ;("DEANNE","0.011")
    ;("LILIAN","0.011")
    ;("JULIANA","0.011")
    ;("ALINE","0.011")
    ;("LUANN","0.011")
    ;("KASEY","0.011")
    ;("MARYANNE","0.011")
    ;("EVANGELINE","0.011")
    ;("COLETTE","0.011")
    ;("MELVA","0.011")
    ;("LAWANDA","0.011")
    ;("YESENIA","0.011")
    ;("NADIA","0.011")
    ;("MADGE","0.011")
    ;("KATHIE","0.011")
    ;("EDDIE","0.011")
    ;("OPHELIA","0.011")
    ;("VALERIA","0.011")
    ;("NONA","0.011")
    ;("MITZI","0.011")
    ;("MARI","0.011")
    ;("GEORGETTE","0.011")
    ;("CLAUDINE","0.011")
    ;("FRAN","0.011")
    ;("ALISSA","0.011")
    ;("ROSEANN","0.01")
    ;("LAKEISHA","0.01")
    ;("SUSANNA","0.01")
    ;("REVA","0.01")
    ;("DEIDRE","0.01")
    ;("CHASITY","0.01")
    ;("SHEREE","0.01")
    ;("CARLY","0.01")
    ;("JAMES","0.01")
    ;("ELVIA","0.01")
    ;("ALYCE","0.01")
    ;("DEIRDRE","0.01")
    ;("GENA","0.01")
    ;("BRIANA","0.01")
    ;("ARACELI","0.01")
    ;("KATELYN","0.01")
    ;("ROSANNE","0.01")
    ;("WENDI","0.01")
    ;("TESSA","0.01")
    ;("BERTA","0.01")
    ;("MARVA","0.01")
    ;("IMELDA","0.01")
    ;("MARIETTA","0.01")
    ;("MARCI","0.01")
    ;("LEONOR","0.01")
    ;("ARLINE","0.01")
    ;("SASHA","0.01")
    ;("MADELYN","0.01")
    ;("JANNA","0.01")
    ;("JULIETTE","0.01")
    ;("DEENA","0.01")
    ;("AURELIA","0.01")
    ;("JOSEFA","0.01")
    ;("AUGUSTA","0.01")
    ;("LILIANA","0.01")
    ;("YOUNG","0.01")
    ;("CHRISTIAN","0.01")
    ;("LESSIE","0.01")
    ;("AMALIA","0.01")
    ;("SAVANNAH","0.01")
    ;("ANASTASIA","0.01")
    ;("VILMA","0.01")
    ;("NATALIA","0.01")
    ;("ROSELLA","0.01")
    ;("LYNNETTE","0.01")
    ;("CORINA","0.01")
    ;("ALFREDA","0.009")
    ;("LEANNA","0.009")
    ;("CAREY","0.009")
    ;("AMPARO","0.009")
    ;("COLEEN","0.009")
    ;("TAMRA","0.009")
    ;("AISHA","0.009")
    ;("WILDA","0.009")
    ;("KARYN","0.009")
    ;("CHERRY","0.009")
    ;("QUEEN","0.009")
    ;("MAURA","0.009")
    ;("MAI","0.009")
    ;("EVANGELINA","0.009")
    ;("ROSANNA","0.009")
    ;("HALLIE","0.009")
    ;("ERNA","0.009")
    ;("ENID","0.009")
    ;("MARIANA","0.009")
    ;("LACY","0.009")
    ;("JULIET","0.009")
    ;("JACKLYN","0.009")
    ;("FREIDA","0.009")
    ;("MADELEINE","0.009")
    ;("MARA","0.009")
    ;("HESTER","0.009")
    ;("CATHRYN","0.009")
    ;("LELIA","0.009")
    ;("CASANDRA","0.009")
    ;("BRIDGETT","0.009")
    ;("ANGELITA","0.009")
    ;("JANNIE","0.009")
    ;("DIONNE","0.009")
    ;("ANNMARIE","0.009")
    ;("KATINA","0.009")
    ;("BERYL","0.009")
    ;("PHOEBE","0.009")
    ;("MILLICENT","0.009")
    ;("KATHERYN","0.009")
    ;("DIANN","0.009")
    ;("CARISSA","0.009")
    ;("MARYELLEN","0.009")
    ;("LIZ","0.009")
    ;("LAURI","0.009")
    ;("HELGA","0.009")
    ;("GILDA","0.009")
    ;("ADRIAN","0.009")
    ;("RHEA","0.009")
    ;("MARQUITA","0.009")
    ;("HOLLIE","0.009")
    ;("TISHA","0.009")
    ;("TAMERA","0.009")
    ;("ANGELIQUE","0.009")
    ;("FRANCESCA","0.009")
    ;("BRITNEY","0.009")
    ;("KAITLIN","0.009")
    ;("LOLITA","0.009")
    ;("FLORINE","0.009")
    ;("ROWENA","0.009")
    ;("REYNA","0.009")
    ;("TWILA","0.009")
    ;("FANNY","0.009")
    ;("JANELL","0.009")
    ;("INES","0.009")
    ;("CONCETTA","0.009")
    ;("BERTIE","0.009")
    ;("ALBA","0.009")
    ;("BRIGITTE","0.009")
    ;("ALYSON","0.009")
    ;("VONDA","0.008")
    ;("PANSY","0.008")
    ;("ELBA","0.008")
    ;("NOELLE","0.008")
    ;("LETITIA","0.008")
    ;("KITTY","0.008")
    ;("DEANN","0.008")
    ;("BRANDIE","0.008")
    ;("LOUELLA","0.008")
    ;("LETA","0.008")
    ;("FELECIA","0.008")
    ;("SHARLENE","0.008")
    ;("LESA","0.008")
    ;("BEVERLEY","0.008")
    ;("ROBERT","0.008")
    ;("ISABELLA","0.008")
    ;("HERMINIA","0.008")
    ;("TERRA","0.008")
    ;("CELINA","0.008")
  |]
let maleFirstNamesAndFrequenciesArray=
  [|
    ("JAMES","3.318")
    ;("JOHN","3.271")
    ;("ROBERT","3.143")
    ;("MICHAEL","2.629")
    ;("WILLIAM","2.451")
    ;("DAVID","2.363")
    ;("RICHARD","1.703")
    ;("CHARLES","1.523")
    ;("JOSEPH","1.404")
    ;("THOMAS","1.38")
    ;("CHRISTOPHER","1.035")
    ;("DANIEL","0.974")
    ;("PAUL","0.948")
    ;("MARK","0.938")
    ;("DONALD","0.931")
    ;("GEORGE","0.927")
    ;("KENNETH","0.826")
    ;("STEVEN","0.78")
    ;("EDWARD","0.779")
    ;("BRIAN","0.736")
    ;("RONALD","0.725")
    ;("ANTHONY","0.721")
    ;("KEVIN","0.671")
    ;("JASON","0.66")
    ;("MATTHEW","0.657")
    ;("GARY","0.65")
    ;("TIMOTHY","0.64")
    ;("JOSE","0.613")
    ;("LARRY","0.598")
    ;("JEFFREY","0.591")
    ;("FRANK","0.581")
    ;("SCOTT","0.546")
    ;("ERIC","0.544")
    ;("STEPHEN","0.54")
    ;("ANDREW","0.537")
    ;("RAYMOND","0.488")
    ;("GREGORY","0.441")
    ;("JOSHUA","0.435")
    ;("JERRY","0.432")
    ;("DENNIS","0.415")
    ;("WALTER","0.399")
    ;("PATRICK","0.389")
    ;("PETER","0.381")
    ;("HAROLD","0.371")
    ;("DOUGLAS","0.367")
    ;("HENRY","0.365")
    ;("CARL","0.346")
    ;("ARTHUR","0.335")
    ;("RYAN","0.328")
    ;("ROGER","0.322")
    ;("JOE","0.321")
    ;("JUAN","0.316")
    ;("JACK","0.315")
    ;("ALBERT","0.314")
    ;("JONATHAN","0.313")
    ;("JUSTIN","0.311")
    ;("TERRY","0.311")
    ;("GERALD","0.309")
    ;("KEITH","0.308")
    ;("SAMUEL","0.306")
    ;("WILLIE","0.302")
    ;("RALPH","0.282")
    ;("LAWRENCE","0.282")
    ;("NICHOLAS","0.275")
    ;("ROY","0.273")
    ;("BENJAMIN","0.27")
    ;("BRUCE","0.263")
    ;("BRANDON","0.26")
    ;("ADAM","0.259")
    ;("HARRY","0.251")
    ;("FRED","0.251")
    ;("WAYNE","0.249")
    ;("BILLY","0.248")
    ;("STEVE","0.246")
    ;("LOUIS","0.243")
    ;("JEREMY","0.242")
    ;("AARON","0.24")
    ;("RANDY","0.232")
    ;("HOWARD","0.23")
    ;("EUGENE","0.23")
    ;("CARLOS","0.229")
    ;("RUSSELL","0.224")
    ;("BOBBY","0.223")
    ;("VICTOR","0.222")
    ;("MARTIN","0.216")
    ;("ERNEST","0.215")
    ;("PHILLIP","0.213")
    ;("TODD","0.213")
    ;("JESSE","0.209")
    ;("CRAIG","0.206")
    ;("ALAN","0.204")
    ;("SHAWN","0.2")
    ;("CLARENCE","0.197")
    ;("SEAN","0.197")
    ;("PHILIP","0.197")
    ;("CHRIS","0.197")
    ;("JOHNNY","0.195")
    ;("EARL","0.193")
    ;("JIMMY","0.191")
    ;("ANTONIO","0.19")
    ;("DANNY","0.19")
    ;("BRYAN","0.19")
    ;("TONY","0.19")
    ;("LUIS","0.189")
    ;("MIKE","0.189")
    ;("STANLEY","0.186")
    ;("LEONARD","0.186")
    ;("NATHAN","0.185")
    ;("DALE","0.184")
    ;("MANUEL","0.181")
    ;("RODNEY","0.18")
    ;("CURTIS","0.18")
    ;("NORMAN","0.177")
    ;("ALLEN","0.174")
    ;("MARVIN","0.171")
    ;("VINCENT","0.168")
    ;("GLENN","0.167")
    ;("JEFFERY","0.166")
    ;("TRAVIS","0.166")
    ;("JEFF","0.166")
    ;("CHAD","0.165")
    ;("JACOB","0.165")
    ;("LEE","0.162")
    ;("MELVIN","0.162")
    ;("ALFRED","0.162")
    ;("KYLE","0.16")
    ;("FRANCIS","0.16")
    ;("BRADLEY","0.159")
    ;("JESUS","0.155")
    ;("HERBERT","0.155")
    ;("FREDERICK","0.154")
    ;("RAY","0.153")
    ;("JOEL","0.152")
    ;("EDWIN","0.148")
    ;("DON","0.145")
    ;("EDDIE","0.144")
    ;("RICKY","0.141")
    ;("TROY","0.138")
    ;("RANDALL","0.138")
    ;("BARRY","0.134")
    ;("ALEXANDER","0.132")
    ;("BERNARD","0.127")
    ;("MARIO","0.125")
    ;("LEROY","0.125")
    ;("FRANCISCO","0.124")
    ;("MARCUS","0.124")
    ;("MICHEAL","0.123")
    ;("THEODORE","0.123")
    ;("CLIFFORD","0.123")
    ;("MIGUEL","0.122")
    ;("OSCAR","0.122")
    ;("JAY","0.118")
    ;("JIM","0.118")
    ;("TOM","0.117")
    ;("CALVIN","0.115")
    ;("ALEX","0.115")
    ;("JON","0.115")
    ;("RONNIE","0.113")
    ;("BILL","0.112")
    ;("LLOYD","0.112")
    ;("TOMMY","0.112")
    ;("LEON","0.112")
    ;("DEREK","0.112")
    ;("WARREN","0.11")
    ;("DARRELL","0.108")
    ;("JEROME","0.108")
    ;("FLOYD","0.107")
    ;("LEO","0.106")
    ;("ALVIN","0.105")
    ;("TIM","0.104")
    ;("WESLEY","0.104")
    ;("GORDON","0.104")
    ;("DEAN","0.104")
    ;("GREG","0.104")
    ;("JORGE","0.104")
    ;("DUSTIN","0.103")
    ;("PEDRO","0.103")
    ;("DERRICK","0.103")
    ;("DAN","0.101")
    ;("LEWIS","0.099")
    ;("ZACHARY","0.099")
    ;("COREY","0.098")
    ;("HERMAN","0.097")
    ;("MAURICE","0.097")
    ;("VERNON","0.097")
    ;("ROBERTO","0.097")
    ;("CLYDE","0.095")
    ;("GLEN","0.094")
    ;("HECTOR","0.094")
    ;("SHANE","0.093")
    ;("RICARDO","0.093")
    ;("SAM","0.092")
    ;("RICK","0.091")
    ;("LESTER","0.091")
    ;("BRENT","0.09")
    ;("RAMON","0.09")
    ;("CHARLIE","0.09")
    ;("TYLER","0.089")
    ;("GILBERT","0.089")
    ;("GENE","0.087")
    ;("MARC","0.087")
    ;("REGINALD","0.084")
    ;("RUBEN","0.082")
    ;("BRETT","0.082")
    ;("ANGEL","0.082")
    ;("NATHANIEL","0.081")
    ;("RAFAEL","0.081")
    ;("LESLIE","0.081")
    ;("EDGAR","0.08")
    ;("MILTON","0.08")
    ;("RAUL","0.079")
    ;("BEN","0.078")
    ;("CHESTER","0.078")
    ;("CECIL","0.078")
    ;("DUANE","0.077")
    ;("FRANKLIN","0.077")
    ;("ANDRE","0.076")
    ;("ELMER","0.074")
    ;("BRAD","0.073")
    ;("GABRIEL","0.073")
    ;("RON","0.072")
    ;("MITCHELL","0.072")
    ;("ROLAND","0.072")
    ;("ARNOLD","0.072")
    ;("HARVEY","0.072")
    ;("JARED","0.071")
    ;("ADRIAN","0.069")
    ;("KARL","0.069")
    ;("CORY","0.068")
    ;("CLAUDE","0.068")
    ;("ERIK","0.068")
    ;("DARRYL","0.067")
    ;("JAMIE","0.066")
    ;("NEIL","0.066")
    ;("JESSIE","0.065")
    ;("CHRISTIAN","0.065")
    ;("JAVIER","0.065")
    ;("FERNANDO","0.065")
    ;("CLINTON","0.065")
    ;("TED","0.064")
    ;("MATHEW","0.064")
    ;("TYRONE","0.064")
    ;("DARREN","0.064")
    ;("LONNIE","0.064")
    ;("LANCE","0.063")
    ;("CODY","0.063")
    ;("JULIO","0.063")
    ;("KELLY","0.063")
    ;("KURT","0.062")
    ;("ALLAN","0.061")
    ;("NELSON","0.061")
    ;("GUY","0.06")
    ;("CLAYTON","0.06")
    ;("HUGH","0.06")
    ;("MAX","0.059")
    ;("DWAYNE","0.059")
    ;("DWIGHT","0.058")
    ;("ARMANDO","0.058")
    ;("FELIX","0.058")
    ;("JIMMIE","0.058")
    ;("EVERETT","0.057")
    ;("JORDAN","0.056")
    ;("IAN","0.056")
    ;("WALLACE","0.056")
    ;("KEN","0.055")
    ;("BOB","0.055")
    ;("JAIME","0.055")
    ;("CASEY","0.054")
    ;("ALFREDO","0.054")
    ;("ALBERTO","0.053")
    ;("DAVE","0.053")
    ;("IVAN","0.053")
    ;("JOHNNIE","0.052")
    ;("SIDNEY","0.052")
    ;("BYRON","0.052")
    ;("JULIAN","0.052")
    ;("ISAAC","0.051")
    ;("MORRIS","0.051")
    ;("CLIFTON","0.05")
    ;("WILLARD","0.05")
    ;("DARYL","0.05")
    ;("ROSS","0.05")
    ;("VIRGIL","0.049")
    ;("ANDY","0.049")
    ;("MARSHALL","0.049")
    ;("SALVADOR","0.049")
    ;("PERRY","0.049")
    ;("KIRK","0.049")
    ;("SERGIO","0.049")
    ;("MARION","0.048")
    ;("TRACY","0.048")
    ;("SETH","0.048")
    ;("KENT","0.048")
    ;("TERRANCE","0.048")
    ;("RENE","0.048")
    ;("EDUARDO","0.047")
    ;("TERRENCE","0.047")
    ;("ENRIQUE","0.046")
    ;("FREDDIE","0.046")
    ;("WADE","0.045")
  |]

let firstNamesAndFrequenciesArray,gender =
  let rnd=System.Random()
  let n= rnd.NextDouble()
  match n with 
    | x when x>0.5->femaleFirstNamesAndFrequenciesArray,"Female"
    |_->maleFirstNamesAndFrequenciesArray, "Male"

let firstNameProbabilityComputer (x:string*string) = System.Double.Parse((snd x).TrimEnd('%'))
let firstNameAndFrequenciesList =
  firstNamesAndFrequenciesArray |> Array.toList |> List.map(fun x->(x,firstNameProbabilityComputer(x)))
let firstNameAndFrequenciesSum =
  fst (firstNameAndFrequenciesList
  |> List.mapFold(fun acc x->
    let newAcc=acc+snd x
    ((fst x,newAcc), newAcc)
    ) 0.0)
let pickRandomFirstNameAndGender() =
  let maxFirstName=snd firstNameAndFrequenciesSum.[firstNameAndFrequenciesSum.Length-1]
  let rnd=System.Random()
  let newNum=rnd.NextDouble()*maxFirstName
  let filteredList=firstNameAndFrequenciesSum|>List.filter(fun x->newNum<(snd x))
  let chosen=fst (fst filteredList.[0])
  chosen,gender

let pickRandomFirstName() =
  let maxFirstName=snd firstNameAndFrequenciesSum.[firstNameAndFrequenciesSum.Length-1]
  let rnd=System.Random()
  let newNum=rnd.NextDouble()*maxFirstName
  let filteredList=firstNameAndFrequenciesSum|>List.filter(fun x->newNum<(snd x))
  let chosen=fst (fst filteredList.[0])
  chosen

