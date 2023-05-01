namespace WebExtractions.Tests
{
    internal class Constants
    {
        public const string HtmlContentWithFullData =
@"
<!DOCTYPE html>
<html lang=en>
<meta charset=utf-8>
<head>
<title>
Kempinski Hotel Bristol Berlin, Germany - Booking.com
</title>
</head>
<body>
<h1 class=""item"">
<span class=""fn"" id=""hp_hotel_name"">
Kempinski Hotel Bristol Berlin
</span>
<span class=""nowrap hp__hotel_ratings"">
<span class=""hp__hotel_ratings__stars hp__hotel_ratings__stars__clarification_track"">
<i class=""b-sprite stars ratings_stars_5  star_track"" title=""This is the official star rating given to the property by an independent third party - the Hotelstars Union. The property is compared to the industry standard and scored based on price, facilities and services offered. Use the star rating to help choose your stay!""><span class=""invisible_spoken"">This is the official star rating given to the property by an independent third party - the Hotelstars Union. The property is compared to the industry standard and scored based on price, facilities and services offered. Use the star rating to help choose your stay!</span></i>
</span>
<i class=""b-sprite icon_deal_smart jq_tooltip"" rel=""300"" title=""This property has agreed  to be part of our Preferred Property programme which groups together properties that stand out thanks to their excellent service and quality/price ratio with competitive prices. Participation in the programme requires meeting a specific set of criteria and takes into account feedback from previous guests.""><span class=""invisible_spoken"">This property has agreed  to be part of our Preferred Property programme which groups together properties that stand out thanks to their excellent service and quality/price ratio with competitive prices. Participation in the programme requires meeting a specific set of criteria and takes into account feedback from previous guests.</span></i>
</span>
</h1>
<span id=""hp_address_subtitle"" class=""jq_tooltip"" rel=""14"">
Kurfürstendamm 27, Charlottenburg-Wilmersdorf, 10719 Berlin, Germany
</span>
<div class=""hotel_large_photp_score
featured_review_score"" id=""js--hp-gallery-scorecard"">
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"" rel=""reviews"">
<span class=""
 js--hp-scorecard-scoreword"">
Very good
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval"">8.3</span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count"">1401</strong> reviews
</span>
</div>
<div id=""summary"" class="""">
<p>This 5-star hotel on Berlin’s Kurfürstendamm shopping street offers elegant rooms, an indoor pool and great public transport links. It is 600 metres from the Gedächtniskirche Church and Berlin Zoo.</p>
<p>Kempinski Hotel Bristol Berlin offers air-conditioned rooms with large windows, modern bathrooms and international TV channels. Bathrobes are provided. Free WiFi is available in all areas and high-speed WiFi access can be booked at an additional cost.</p>
<p>Gourmet cuisine is served in the popular Kempinski Grill. Reinhard's brasserie offer light cuisine and a terrace overlooking Kurfürstendamm. Guests can enjoy drinks in the Gobelin Halle lounge or in the Bristol Bar.</p>
<p>Kempinski Bristol Berlin’s spa includes a sauna, steam room and gym. Massages and beauty treatments can also be booked here. The hotel's business centre can be used free of charge.</p>
<p>Uhlandstraße Underground Station is just outside the Kempinski’s front door. The KaDeWe shopping mall is 2 stops away. 
<br></p>
</div>
<table class=""roomstable rt_no_dates __big-buttons rt_lightbox_enabled "" id=""maxotel_rooms"" cellspacing=""0"" border=""2"">
<thead>
<tr id=""maxotel_table_header"">
<th class=""figure"">Max</th>
<th>Room type</th>
<th class=""figure"" style=""white-space:normal"">
</th>
</tr>
</thead>
<tbody>
<tr class=""odd first"">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
Suite with Balcony
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""even "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
Classic Double or Twin Room
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""odd "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
Superior Double or Twin Room
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""even "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
Deluxe Double Room
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""odd "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
Deluxe Business Suite
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""even "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
Junior Suite
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""odd "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
Family Room
</td>
<td class=""rt_show_dates"">
</td>
</tr>
</tbody>
</table>
<table cellspacing=""0"" id=""althotelsTable"" style=""table-layout:fixed;width:100%;"">
<tbody><tr id=""althotelsRow"">
<td class=""althotelsCell tracked"" id=""althotelCol_1"">
<p class=""althotels-name"">
<a class=""althotel_link"">
Hotel Adlon Kempinski Berlin
</a>
<i class=""b-sprite ratings_stars_5_sm"" title=""5-star hotel""><span class=""invisible_spoken"">5-star hotel</span></i>
</p>
<span class=""hp_compset_description"">
The quintessence of luxury lodging, the Adlon is a legendary 5-star hotel situated in Berlin’s Mitte, beside the Brandenburg Gate. 
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count"">1933</strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Superb
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval"">9.4</span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
<td class=""althotelsCell tracked"" id=""althotelCol_2"">
<p class=""althotels-name"">
<a class=""althotel_link"">
Grand Hyatt Berlin
</a>
<i class=""b-sprite ratings_stars_5_sm"" title=""5-star hotel""><span class=""invisible_spoken"">5-star hotel</span></i>
</p>
<span class=""hp_compset_description"">
This 5-star hotel has a large rooftop spa and pool with spectacular views of Berlin. 
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count"">1460</strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Superb
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval"">9.1</span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
<td class=""althotelsCell tracked"" id=""althotelCol_3"">
<p class=""althotels-name"">
<a class=""althotel_link"">
Sofitel Berlin Kurfürstendamm
</a>
<i class=""b-sprite ratings_stars_5_sm"" title=""5-star hotel""><span class=""invisible_spoken"">5-star hotel</span></i>
</p>
<span class=""hp_compset_description"">
Just 100 metres from the Kurfürstendamm boulevard, this 5-star design hotel offers air-conditioned rooms, free Wi-Fi and a French restaurant. Guests have free use of the spa and gym. 
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count"">1497</strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Superb
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval"">9</span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
<td class=""althotelsCell tracked"" style=""padding-right: 0; "" id=""althotelCol_4"">
<p class=""althotels-name"">
<a class=""althotel_link"">
Hilton Berlin
</a>
<i class=""
estimated_rating
b-sprite
5_sm
no_empty_circles
"" title=""Estimated rating: 5/5""><span class=""invisible_spoken"">Estimated rating: 5/5</span></i>
</p>
<span class=""hp_compset_description"">
This centrally located hotel on Berlin’s historic Gendarmenmarkt Square features luxurious rooms, an exclusive spa and 2 restaurants with stunning views of the German Cathedral. 
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count"">2700</strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Very good
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval"">8.5</span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
</tr>
</tbody></table>
</body>
</html>
";

        public const string JsonStringForHtmlContentWithFullData =
@"{
  ""Name"": ""Kempinski Hotel Bristol Berlin"",
  ""Address"": ""Kurfürstendamm 27, Charlottenburg-Wilmersdorf, 10719 Berlin, Germany"",
  ""Stars"": 5,
  ""ReviewPoints"": 8.3,
  ""ReviewsCount"": 1401,
  ""Description"": ""This 5-star hotel on Berlin’s Kurfürstendamm shopping street offers elegant rooms, an indoor pool and great public transport links. It is 600 metres from the Gedächtniskirche Church and Berlin Zoo.\r\nKempinski Hotel Bristol Berlin offers air-conditioned rooms with large windows, modern bathrooms and international TV channels. Bathrobes are provided. Free WiFi is available in all areas and high-speed WiFi access can be booked at an additional cost.\r\nGourmet cuisine is served in the popular Kempinski Grill. Reinhard\u0027s brasserie offer light cuisine and a terrace overlooking Kurfürstendamm. Guests can enjoy drinks in the Gobelin Halle lounge or in the Bristol Bar.\r\nKempinski Bristol Berlin’s spa includes a sauna, steam room and gym. Massages and beauty treatments can also be booked here. The hotel\u0027s business centre can be used free of charge.\r\nUhlandstraße Underground Station is just outside the Kempinski’s front door. The KaDeWe shopping mall is 2 stops away. \n"",
  ""RoomCategories"": [
    ""Suite with Balcony"",
    ""Classic Double or Twin Room"",
    ""Superior Double or Twin Room"",
    ""Deluxe Double Room"",
    ""Deluxe Business Suite"",
    ""Junior Suite"",
    ""Family Room""
  ],
  ""AlternativeHotels"": [
    {
      ""Name"": ""Hotel Adlon Kempinski Berlin"",
      ""Stars"": 5,
      ""ReviewPoints"": 9.4,
      ""ReviewsCount"": 1933,
      ""Description"": ""The quintessence of luxury lodging, the Adlon is a legendary 5-star hotel situated in Berlin’s Mitte, beside the Brandenburg Gate.""
    },
    {
      ""Name"": ""Grand Hyatt Berlin"",
      ""Stars"": 5,
      ""ReviewPoints"": 9.1,
      ""ReviewsCount"": 1460,
      ""Description"": ""This 5-star hotel has a large rooftop spa and pool with spectacular views of Berlin.""
    },
    {
      ""Name"": ""Sofitel Berlin Kurfürstendamm"",
      ""Stars"": 5,
      ""ReviewPoints"": 9,
      ""ReviewsCount"": 1497,
      ""Description"": ""Just 100 metres from the Kurfürstendamm boulevard, this 5-star design hotel offers air-conditioned rooms, free Wi-Fi and a French restaurant. Guests have free use of the spa and gym.""
    },
    {
      ""Name"": ""Hilton Berlin"",
      ""Stars"": 0,
      ""ReviewPoints"": 8.5,
      ""ReviewsCount"": 2700,
      ""Description"": ""This centrally located hotel on Berlin’s historic Gendarmenmarkt Square features luxurious rooms, an exclusive spa and 2 restaurants with stunning views of the German Cathedral.""
    }
  ]
}";

        public const string HtmlContentWithInvalidData =
@"
<!DOCTYPE html>
<html lang=en>
<meta charset=utf-8>
<head>
<title>
</title>
</head>
<body>
<h1 class=""item"">
<span class=""fn"" id=""hp_hotel_name"">
</span>
<span class=""nowrap hp__hotel_ratings"">
<span class=""hp__hotel_ratings__stars hp__hotel_ratings__stars__clarification_track"">
<i class=""b-sprite stars star_track""><span class=""invisible_spoken""></span></i>
</span>
</span>
</h1>
<span id=""hp_address_subtitle"" class=""jq_tooltip"" rel=""14"">
</span>
<div class=""hotel_large_photp_score
featured_review_score"" id=""js--hp-gallery-scorecard"">
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"" rel=""reviews"">
<span class=""
 js--hp-scorecard-scoreword"">
Very good
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval""></span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count""></strong> reviews
</span>
</div>
<div id=""summary"" class="""">
</div>
<table class=""roomstable rt_no_dates __big-buttons rt_lightbox_enabled "" id=""maxotel_rooms"" cellspacing=""0"" border=""2"">
<thead>
<tr id=""maxotel_table_header"">
<th class=""figure"">Max</th>
<th>Room type</th>
<th class=""figure"" style=""white-space:normal"">
</th>
</tr>
</thead>
<tbody>
<tr class=""odd first"">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""even "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""odd "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""even "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""odd "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""even "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
</td>
<td class=""rt_show_dates"">
</td>
</tr>
<tr class=""odd "">
<td class=""occ_no_dates"" style="" border-left: 0 none; border-right: 1px solid #96b2d9;
"">
</td>
<td class=""ftd"">
</td>
<td class=""rt_show_dates"">
</td>
</tr>
</tbody>
</table>
<table cellspacing=""0"" id=""althotelsTable"" style=""table-layout:fixed;width:100%;"">
<tbody><tr id=""althotelsRow"">
<td class=""althotelsCell tracked"" id=""althotelCol_1"">
<p class=""althotels-name"">
<a class=""althotel_link"">
</a>
<i class=""b-sprite ratings_stars_5_sm"" title=""5-star hotel""><span class=""invisible_spoken""></span></i>
</p>
<span class=""hp_compset_description"">
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count""></strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Superb
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval""></span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
<td class=""althotelsCell tracked"" id=""althotelCol_2"">
<p class=""althotels-name"">
<a class=""althotel_link"">
</a>
<i class=""b-sprite ratings_stars_5_sm"" title=""5-star hotel""><span class=""invisible_spoken""></span></i>
</p>
<span class=""hp_compset_description"">
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count""></strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Superb
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval""></span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
<td class=""althotelsCell tracked"" id=""althotelCol_3"">
<p class=""althotels-name"">
<a class=""althotel_link"">
</a>
<i class=""b-sprite ratings_stars_5_sm"" title=""5-star hotel""><span class=""invisible_spoken""></span></i>
</p>
<span class=""hp_compset_description"">
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count""></strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Superb
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval""></span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
<td class=""althotelsCell tracked"" style=""padding-right: 0; "" id=""althotelCol_4"">
<p class=""althotels-name"">
<a class=""althotel_link"">
</a>
<i class=""
estimated_rating
b-sprite
5_sm
no_empty_circles
"" title=""Estimated rating: 5/5""><span class=""invisible_spoken""></span></i>
</p>
<span class=""hp_compset_description"">
</span>
<div class=""althotelsDiv alt_hotels_info_row"">
<span class=""trackit score_from_number_of_reviews"">
Score from <strong class=""count""></strong> reviews
</span>
<a class=""big_review_score_detailed js-big_review_score_detailed ind_rev_total hp_review_score"">
<span class=""
 js--hp-scorecard-scoreword"">
Very good
</span>
<span class=""rating notranslate"">
<span class=""average js--hp-scorecard-scoreval""></span><span class=""out_of"">/<span class=""best"">10</span></span>
</span>
</a>
</div>
</td>
</tr>
</tbody></table>
</body>
</html>
";
        public const string JsonStringForHtmlContentWithInvalidData =
@"{
  ""Name"": """",
  ""Address"": """",
  ""Stars"": 0,
  ""ReviewPoints"": 0,
  ""ReviewsCount"": 0,
  ""Description"": """",
  ""RoomCategories"": [
    """",
    """",
    """",
    """",
    """",
    """",
    """"
  ],
  ""AlternativeHotels"": [
    {
      ""Name"": """",
      ""Stars"": 0,
      ""ReviewPoints"": 0,
      ""ReviewsCount"": 0,
      ""Description"": """"
    },
    {
      ""Name"": """",
      ""Stars"": 0,
      ""ReviewPoints"": 0,
      ""ReviewsCount"": 0,
      ""Description"": """"
    },
    {
      ""Name"": """",
      ""Stars"": 0,
      ""ReviewPoints"": 0,
      ""ReviewsCount"": 0,
      ""Description"": """"
    },
    {
      ""Name"": """",
      ""Stars"": 0,
      ""ReviewPoints"": 0,
      ""ReviewsCount"": 0,
      ""Description"": """"
    }
  ]
}";
    }
}
