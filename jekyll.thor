require "stringex"
class Jekyll < Thor
  desc "new", "create a new post"
  method_option :editor, :default => "subl"
  def new(*title)
    title = title.join(" ")
    date = Time.now.strftime('%Y-%m-%d')
    hour = Time.now.strftime('%H:%M:%S')
    filename = "_posts/#{date}-#{title.to_url}.md"

    if File.exist?(filename)
      abort("#{filename} already exists!")
    end

    puts "Creating new post: #{filename}"
    open(filename, 'w') do |post|
      post.puts "---"
      post.puts "layout: post"
      post.puts "title: \"#{title.gsub(/&/,'&amp;')}\""
      post.puts "date: #{date} #{hour}"
      post.puts "summary: -Your Summary Here-"
      post.puts "category: "
      post.puts "tags: "
      post.puts "image: /images/default-thumb.png"
      post.puts "---"
    end

    system(options[:editor], filename)
  end

  desc "tag", "create a new tag"
  method_option :editor, :default => "subl"
  def tag(*name)
    tag_name = name.join(" ")
    tag_dasherized_name = tag_name.downcase.split(" ").join("-")
    filename = "tags/#{tag_dasherized_name}.md"

    if File.exist?(filename)
      abort("#{filename} already exists!")
    end

    puts "Creating new tag: #{filename}"
    open(filename, 'w') do |tag|
      tag.puts "---"
      tag.puts "layout: blog_by_tag"
      tag.puts "tag: #{tag_dasherized_name}"
      tag.puts "permalink: /tags/#{tag_dasherized_name}/"
      tag.puts "---"
    end

    puts "Updating tag list"
    open("_data/tags.yml", "a+") do |tag|
      tag.puts ""
      tag.puts "- slug: #{tag_dasherized_name}"
      tag.puts "  name: #{tag_name}"
    end

    system(options[:editor], filename)
  end
end